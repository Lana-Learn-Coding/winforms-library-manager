using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel
    {
        [Reactive] public BookItem SelectedHistoryBook { get; set; } = new();
        [Reactive] public ObservableCollection<BookItem> HistoryBooks { get; set; } = new();
        public ReactiveCommand<Unit, Unit> RefreshHistoryCommand { get; set; }

        private void InitializeHistoryTab()
        {
            RefreshHistory();
            RefreshHistoryCommand = ReactiveCommand.Create(RefreshHistory);
        }

        private void RefreshHistory()
        {
            HistoryBooks = BorrowedBooks = new ObservableCollection<BookItem>(Reader.Tickets
                .SelectMany(ticket => ticket.BookItems)
                .Distinct());
        }
    }
}