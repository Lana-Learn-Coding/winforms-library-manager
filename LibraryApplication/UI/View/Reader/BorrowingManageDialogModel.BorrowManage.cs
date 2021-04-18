using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel
    {
        [Reactive] public ObservableCollection<BookItem> BorrowedBooks { get; set; } = new();
        [Reactive] public bool IsSafeModeEnabled { get; set; } = true;
        public ReactiveCommand<int, Unit> RemoveBookCommand { get; set; }
        public ReactiveCommand<int, Unit> ReturnBookCommand { get; set; }
        public ReactiveCommand<int, Unit> ReturnTicketCommand { get; set; }
        public ReactiveCommand<int, Unit> ExtendDueDateCommand { get; set; }
        public ReactiveCommand<int, Unit> ExtendTicketDueDateCommand { get; set; }

        private void InitializeBorrowManageTab()
        {
            BorrowedBooks = new ObservableCollection<BookItem>(Reader.Tickets.Where(ticket => !ticket.isReturned)
                .SelectMany(ticket => ticket.BookItems)
                .Distinct());

            var isNotEmpty = this.WhenAnyValue(vm => vm.BorrowableBooks)
                .Select(list => list.Count > 0);

            var isRemovable = this.WhenAnyValue(
                vm => vm.BorrowableBooks,
                vm => vm.IsSafeModeEnabled,
                (list, isSafe) => list.Count > 0 && !isSafe);

            RemoveBookCommand = ReactiveCommand.Create<int>(RemoveBook, isRemovable);
            ReturnBookCommand = ReactiveCommand.Create<int>(ReturnBook, isNotEmpty);
            ReturnTicketCommand = ReactiveCommand.Create<int>(ReturnTicket, isNotEmpty);

            ExtendDueDateCommand = ReactiveCommand.Create<int>(ReturnTicket, isNotEmpty);
            ExtendTicketDueDateCommand = ReactiveCommand.Create<int>(ReturnTicket, isNotEmpty);
        }

        private void RemoveBook(int bookId)
        {
        }

        private void ReturnBook(int bookId)
        {
        }

        private void ReturnTicket(int bookId)
        {
        }
    }
}