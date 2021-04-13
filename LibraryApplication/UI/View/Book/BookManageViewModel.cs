using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Windows.Forms;
using LibraryApplication.Model;
using LibraryApplication.Model.Book;
using MaterialSkin.Controls;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;
using ReactiveUI.Validation.Extensions;
using Splat;

namespace LibraryApplication.UI.View.Book
{
    public class BookManageViewModel : ReactiveObject, IValidatableViewModel
    {
        private readonly ModelContext _context;
        public ValidationContext ValidationContext { get; } = new();

        [Reactive] public BookMeta SelectedItem { get; set; }
        [Reactive] public ObservableCollection<BookMeta> Items { get; set; }

        public ReactiveCommand<Unit, Unit> ClearSelectionCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveCommand { get; }
        public ReactiveCommand<Unit, Unit> DeleteCommand { get; }

        public BookManageViewModel()
        {
            _context = Locator.Current.GetService<ModelContext>();
            Items = _context.Books.Local;
            SelectedItem = new BookMeta();

            this.ValidationRule(
                model => model.SelectedItem.Title,
                title => !string.IsNullOrWhiteSpace(title),
                "Title must not blank"
            );
            this.ValidationRule(
                model => model.SelectedItem.Year,
                year => year > 0,
                "Year must >= 0"
            );
            this.ValidationRule(
                model => model.SelectedItem.Category,
                category => category != null,
                "Please select Category"
            );
            this.ValidationRule(
                model => model.SelectedItem.Publisher,
                val => val != null,
                "Please select Publisher"
            );

            this.ValidationRule(
                model => model.SelectedItem.Author,
                val => val != null,
                "Please select Author"
            );

            this.ValidationRule(
                model => model.SelectedItem.Series,
                val => val != null,
                "Please select Series"
            );

            ClearSelectionCommand = ReactiveCommand.Create(ClearSelection);
            DeleteCommand = ReactiveCommand.Create(DeleteSelection);
            SaveCommand = ReactiveCommand.Create(Save);
        }

        public void OnRowSelected(int id)
        {
            if (id <= 0)
            {
                ClearSelection();
                return;
            }

            SelectedItem = Items.First(book => book.Id == id);
        }

        private void ClearSelection()
        {
            SelectedItem = new BookMeta();
        }

        private void DeleteSelection()
        {
            var result = MaterialMessageBox.Show("Are you sure delete?", "Warning", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;
            _context.Books.Remove(SelectedItem);
            _context.SaveChanges();
            ClearSelection();
        }

        private void Save()
        {
            if (SelectedItem.Id == null)
            {
                _context.Books.Add(SelectedItem);
            }
            else
            {
                _context.Entry(SelectedItem).CurrentValues.SetValues(SelectedItem);
            }

            var item = SelectedItem;
            _context.SaveChanges();
            ClearSelection();
            SelectedItem = item;
        }
    }
}