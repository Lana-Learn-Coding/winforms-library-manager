using System.Reactive;
using System.Windows;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel
    {
        [Reactive] public Ticket NewTicket { get; set; } = new();

        public ReactiveCommand<Unit, Unit> SaveNewTicketCommand;
        public ReactiveCommand<Unit, Unit> ClearNewTicketCommand;

        private void InitializeNewTicketTab()
        {
            SaveNewTicketCommand = ReactiveCommand.Create(SaveNewTicket);
            ClearNewTicketCommand = ReactiveCommand.Create(() => { NewTicket = new Ticket(); });
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

            NewTicket.Reader = Reader;
            ModelContext.Tickets.Add(NewTicket);
            ModelContext.SaveChanges();
            MessageBox.Show($"Ticket {NewTicket.Id} created. Due date: {NewTicket.DueDate.Value:yyyy-MM-dd}",
                "Success");
            NewTicket = new Ticket();
        }
    }
}