using System.Collections.ObjectModel;
using LibraryApplication.Model.Book;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Book
{
    public class BookItemManageDialogModel : DataFormViewModel<BookItem>
    {
        private BookMeta Meta { get; }

        public BookItemManageDialogModel(BookMeta meta)
        {
            Meta = meta;
            Items = new ObservableCollection<BookItem>(Meta.Items);

            this.ValidationRule(
                model => model.SelectedItem.Position,
                val => val != null,
                "Please select Position"
            );
            this.ValidationRule(
                model => model.SelectedItem.Storage,
                val => val != null,
                "Please select Storage"
            );
        }

        protected override void CreateNewItem(BookItem item)
        {
            SelectedItem.BookMeta = Meta;
            Context.BookItems.Add(item);
            Context.SaveChanges();
            Items.Add(item);
        }
    }
}