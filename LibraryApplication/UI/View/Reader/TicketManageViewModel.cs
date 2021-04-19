using System;
using System.Data.Entity;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Reader
{
    public class TicketManageViewModel : DataFormViewModel<Ticket>
    {
        [Reactive] public bool ShowBorrowBookDialog { get; set; }

        public readonly ReactiveCommand<Unit, bool> ToggleBorrowBookCommand;
        public readonly ReactiveCommand<Unit, Unit> ReturnBookCommand;

        public TicketManageViewModel()
        {
            this.ValidationRule(
                model => model.SelectedItem.Id,
                id => id is > 0,
                "Please select some thing"
            );

            var isReturnable = this.WhenAnyValue(model => model.SelectedItem)
                .Select(ticket => ticket.Id != null && !ticket.ReturnedDate.HasValue);
            ReturnBookCommand = ReactiveCommand.Create(ReturnTicket, isReturnable);

            var isSelected = this.WhenAnyValue(model => model.IsUpdating);
            ToggleBorrowBookCommand =
                ReactiveCommand.Create(() => ShowBorrowBookDialog = !ShowBorrowBookDialog, isSelected);
        }

        public override void LoadData()
        {
            Context.Tickets.Load();
            Items = Context.Tickets.Local;
        }

        private void ReturnTicket()
        {
            if (SelectedItem.isReturned)
            {
                MessageBox.Show("Ticket already returned!", "Info");
                return;
            }

            var result = MessageBox.Show($"Are you sure return ticket {SelectedItem.Id}?", "Warning",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            foreach (var bookItem in SelectedItem.BookItems)
            {
                bookItem.BorrowingTicket = null;
            }

            SelectedItem.ReturnedDate = DateTime.Now;
            Context.Entry(SelectedItem).CurrentValues.SetValues(SelectedItem);
            Context.SaveChanges();
            RefreshSelection();
        }

        protected override void OnSaving()
        {
            if (SelectedItem.Id != null) return;
            throw new Exception("Please select a ticket");
        }

        protected override void OnDeleting()
        {
            if (SelectedItem.isReturned) return;
            throw new Exception("Cannot delete a borrowing ticket");
        }
    }
}