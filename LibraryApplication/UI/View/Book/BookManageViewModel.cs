using System;
using System.Data.Entity;
using System.Reactive;
using LibraryApplication.Model.Book;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Book
{
    public class BookManageViewModel : DataFormViewModel<BookMeta>
    {
        [Reactive] public bool ShowViewBooksDialog { get; set; }

        public readonly ReactiveCommand<Unit, bool> ToggleViewBooksDialogCommand;

        public BookManageViewModel()
        {
            this.ValidationRule(
                model => model.SelectedItem.Title,
                title => !string.IsNullOrWhiteSpace(title),
                "Title must not blank"
            );
            this.ValidationRule(
                model => model.SelectedItem.Year,
                year => year > 0 && year <= DateTime.Today.Year,
                "Year is invalid"
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

            var isSelected = this.WhenAnyValue(model => model.IsUpdating);
            ToggleViewBooksDialogCommand =
                ReactiveCommand.Create(() => ShowViewBooksDialog = !ShowViewBooksDialog, isSelected);
        }

        public override void LoadData()
        {
            Context.Books.Load();
            OriginalItems = Context.Books.Local;
        }

        protected override bool Filter(BookMeta item, string filter)
        {
            return
                item.Title.Contains(filter) ||
                item.Publisher.Name.Contains(filter) ||
                item.Author.Name.Contains(filter) ||
                item.Category.Name.Contains(filter) ||
                item.Series.Name.Contains(filter);
        }
    }
}