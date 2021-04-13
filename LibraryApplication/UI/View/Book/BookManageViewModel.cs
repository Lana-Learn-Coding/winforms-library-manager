﻿using LibraryApplication.Model.Book;
using ReactiveUI.Validation.Extensions;

namespace LibraryApplication.UI.View.Book
{
    public class BookManageViewModel : DataFormViewModel<BookMeta>
    {
        public BookManageViewModel()
        {
            Items = Context.Books.Local;
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
        }
    }
}