using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using LibraryApplication.Model;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace LibraryApplication.UI.View.Book
{
    public class BookManageViewModel : ReactiveObject
    {
        [Reactive] public BookMeta SelectedBook { get; set; }

        [Reactive] public ObservableCollection<BookMeta> Books { get; set; }

        public ReactiveCommand<Unit, Unit> ClearSelectionCommand { get; }

        public BookManageViewModel()
        {
            var context = Locator.Current.GetService<ModelContext>();
            Books = context.Books.Local;

            ClearSelectionCommand = ReactiveCommand.Create(ClearSelection);
        }

        public void OnRowSelected(int id)
        {
            if (id <= 0)
            {
                ClearSelection();
                return;
            }

            SelectedBook = Books.First(book => book.Id == id);
        }

        private void ClearSelection()
        {
            SelectedBook = new BookMeta();
        }
    }
}