using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Windows;
using DynamicData;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel
    {
        [Reactive] public ObservableCollection<BookItem> BorrowableBooks { get; set; } = new();
        [Reactive] public Ticket NewTicket { get; set; } = new();

        public ReactiveCommand<int, Unit> AddBookToListCommand { get; set; }
        public ReactiveCommand<Unit, Unit> SaveNewTicketCommand { get; set; }
        public ReactiveCommand<Unit, Unit> ClearNewTicketCommand { get; set; }

        private void InitializeNewTicketTab()
        {
            BorrowableBooks =
                new ObservableCollection<BookItem>(Context.BookItems.Local.Where(item => item.BorrowingTicket == null));
            SaveNewTicketCommand = ReactiveCommand.Create(SaveNewTicket);
            ClearNewTicketCommand = ReactiveCommand.Create(ClearNewTicket);
            AddBookToListCommand = ReactiveCommand.Create<int>(AddSelectedBookToList);
        }

        private void AddSelectedBookToList(int id)
        {
            if (id <= 0) return;
            var bookItem = BorrowableBooks.First(book => book.Id == id);
            if (bookItem.IsBorrowed)
            {
                bookItem.BorrowingTicket = null;
                NewTicket.BookItems.Remove(bookItem);
                return;
            }

            bookItem.BorrowingTicket = NewTicket;
            NewTicket.BookItems.Add(bookItem);
        }

        private void SaveNewTicket()
        {
            if (NewTicket.Id != null)
            {
                MessageBox.Show("Please clear current ticket", "Error");
                return;
            }

            if (NewTicket.BookItems.Count <= 0)
            {
                MessageBox.Show("Please select some book", "Invalid");
                return;
            }

            NewTicket.BorrowedDate = DateTime.Now;
            NewTicket.Reader = Reader;
            Context.Tickets.Add(NewTicket);
            Context.SaveChanges();
            MessageBox.Show($"Ticket {NewTicket.Id} created. Due date: {NewTicket.DueDate.Value:yyyy-MM-dd}",
                "Success");
            BorrowableBooks.RemoveMany(NewTicket.BookItems);
            ClearNewTicket();
        }

        private void ClearNewTicket()
        {
            foreach (var bookItem in NewTicket.BookItems)
            {
                bookItem.BorrowingTicket = null;
            }

            NewTicket = new Ticket();
        }
    }
}