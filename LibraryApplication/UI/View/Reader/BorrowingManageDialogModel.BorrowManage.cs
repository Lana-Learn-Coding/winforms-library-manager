﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model.Book;
using LibraryApplication.UI.Component;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel
    {
        [Reactive] public BookItem SelectedBorrowedBook { get; set; } = new();
        [Reactive] public ObservableCollection<BookItem> BorrowedBooks { get; set; } = new();
        [Reactive] public bool IsSafeModeEnabled { get; set; } = true;
        public ReactiveCommand<Unit, Unit> RemoveBookCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> ReturnBookCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> ReturnTicketCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> ExtendDueDateCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> ExtendTicketDueDateCommand { get; private set; }
        public ReactiveCommand<Unit, Unit> RefreshBorrowedBooksCommand { get; set; }

        private void InitializeBorrowManageTab()
        {
            RefreshBorrowedBooks();
            var isNotEmpty = this.WhenAnyValue(vm => vm.SelectedBorrowedBook)
                .Select(item => item?.Id != null);

            var isRemovable = this.WhenAnyValue(
                vm => vm.BorrowedBooks,
                vm => vm.IsSafeModeEnabled,
                (list, isSafe) => list.Count > 0 && !isSafe);

            RemoveBookCommand = ReactiveCommand.Create(RemoveBook, isRemovable);
            RemoveBookCommand = ReactiveCommand.Create(RemoveBook, isRemovable);
            ReturnBookCommand = ReactiveCommand.Create(ReturnBook, isNotEmpty);
            ReturnTicketCommand = ReactiveCommand.Create(ReturnTicket, isNotEmpty);

            ExtendDueDateCommand = ReactiveCommand.Create(() => { ExtendDueDate(AskDueDate()); }, isNotEmpty);
            ExtendTicketDueDateCommand =
                ReactiveCommand.Create(() => { ExtendTicketDueDate(AskDueDate()); }, isNotEmpty);
            RefreshBorrowedBooksCommand = ReactiveCommand.Create(RefreshBorrowedBooks);
        }

        private void RefreshBorrowedBooks()
        {
            BorrowedBooks = new ObservableCollection<BookItem>(Reader.Tickets.Where(ticket => !ticket.isReturned)
                .SelectMany(ticket => ticket.BookItems)
                .Distinct());
        }

        private void RemoveBook()
        {
            var result = MessageBox.Show($"Are you sure delete book {SelectedBorrowedBook.Id}?", "Warning",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            var bookItem = SelectedBorrowedBook;
            var borrowingTicket = bookItem.BorrowingTicket;

            BorrowedBooks.Remove(SelectedBorrowedBook);
            borrowingTicket.BookItems.Remove(bookItem);
            if (borrowingTicket.BookItems.Count == 0)
            {
                Context.Tickets.Remove(borrowingTicket);
            }

            Context.BookItems.Remove(bookItem);
            Context.SaveChanges();
            SelectedBorrowedBook = new BookItem();
        }

        private void ReturnBook()
        {
            var result = MessageBox.Show($"Are you sure return book {SelectedBorrowedBook.Id}?", "Confirm",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            var bookItem = SelectedBorrowedBook; // prevent selected book change
            var borrowingTicket = SelectedBorrowedBook.BorrowingTicket;

            if (borrowingTicket.BookItems.Count <= 1)
            {
                ReturnTicket(borrowingTicket);
                return;
            }

            BorrowedBooks.Remove(bookItem);
            borrowingTicket.BookItems.Remove(bookItem);
            bookItem.BorrowingTicket = null;
            var ticket = new Ticket
            {
                BookItems = new ObservableCollection<BookItem> {bookItem},
                BorrowedDate = borrowingTicket.BorrowedDate,
                DueDate = borrowingTicket.DueDate,
                ReturnedDate = DateTime.Now,
                Parent = borrowingTicket,
                Reader = borrowingTicket.Reader
            };

            Context.Tickets.Add(ticket);
            Context.Entry(bookItem).CurrentValues.SetValues(bookItem);
            Context.SaveChanges();
            SelectedBorrowedBook = new BookItem();
        }

        private void ReturnTicket()
        {
            var borrowingTicket = SelectedBorrowedBook.BorrowingTicket;
            var result = MessageBox.Show($"Are you sure return ticket {borrowingTicket.Id}?", "Confirm",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            ReturnTicket(borrowingTicket);
        }

        private void ReturnTicket(Ticket ticket)
        {
            foreach (var bookItem in ticket.BookItems)
            {
                bookItem.BorrowingTicket = null;
                Context.Entry(bookItem).CurrentValues.SetValues(bookItem);
                BorrowedBooks.Remove(bookItem);
            }

            ticket.ReturnedDate = DateTime.Now;
            Context.Entry(ticket).CurrentValues.SetValues(ticket);
            Context.SaveChanges();
            SelectedBorrowedBook = new BookItem();
        }

        private void ExtendTicketDueDate(DateTime newDate)
        {
            var ticket = SelectedBorrowedBook.BorrowingTicket;
            if (newDate == ticket.DueDate)
            {
                return;
            }

            ticket.DueDate = newDate;
            Context.Entry(ticket).CurrentValues.SetValues(ticket);
            Context.SaveChanges();
        }

        private void ExtendDueDate(DateTime newDate)
        {
            var bookItem = SelectedBorrowedBook;
            var borrowingTicket = SelectedBorrowedBook.BorrowingTicket;
            if (borrowingTicket.BookItems.Count == 1)
            {
                ExtendTicketDueDate(newDate);
                return;
            }

            if (newDate == borrowingTicket.DueDate)
            {
                return;
            }

            var result = MessageBox.Show("This will create new ticket", "Confirm",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            borrowingTicket.BookItems.Remove(bookItem);
            var ticket = new Ticket
            {
                BookItems = new ObservableCollection<BookItem> {bookItem},
                BorrowedDate = borrowingTicket.BorrowedDate,
                DueDate = newDate,
                Parent = borrowingTicket,
                Reader = borrowingTicket.Reader
            };
            bookItem.BorrowingTicket = ticket;

            Context.Tickets.Add(ticket);
            Context.Entry(bookItem).CurrentValues.SetValues(bookItem);
            Context.SaveChanges();
        }

        private DateTime AskDueDate()
        {
            var currentDueDate = SelectedBorrowedBook.DueDate ?? DateTime.Now;
            var newDate = PromptDialog.PromptDatePicker(null, "Select new due date", currentDueDate,
                currentDueDate);
            return newDate ?? currentDueDate;
        }
    }
}