using System;
using System.Reactive;
using System.Reactive.Linq;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Reader
{
    public class TicketManageViewModel : DataFormViewModel<Ticket>
    {
        public readonly ReactiveCommand<Unit, Unit> ReturnBookCommand;

        public TicketManageViewModel()
        {
            Items = Context.Tickets.Local;
            this.ValidationRule(
                model => model.SelectedItem.Id,
                id => id is > 0,
                "Please select some thing"
            );

            var isReturnable = this.WhenAnyValue(model => model.SelectedItem)
                .Select(ticket => ticket.Id != null && !ticket.ReturnedDate.HasValue);
            ReturnBookCommand = ReactiveCommand.Create(ReturnTicket, isReturnable);
        }

        private void ReturnTicket()
        {
            if (SelectedItem.ReturnedDate != null)
            {
                return;
            }

            SelectedItem.ReturnedDate = DateTime.Now;
            Context.Entry(SelectedItem).CurrentValues.SetValues(SelectedItem);
            Context.SaveChanges();
            RefreshSelection();
        }

        protected override void OnSaving()
        {
            if (SelectedItem.Id == null)
            {
                throw new Exception("Please select a ticket");
            }
        }

        protected override void OnDeleting()
        {
            throw new Exception("Cannot delete a ticket");
        }
    }
}