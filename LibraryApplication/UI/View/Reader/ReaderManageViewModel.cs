using System;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text.RegularExpressions;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Extensions;
using ReactiveUI.Validation.States;

namespace LibraryApplication.UI.View.Reader
{
    public class ReaderManageViewModel : DataFormViewModel<Model.Book.Reader>
    {
        [Reactive] public bool ShowBorrowBookDialog { get; set; }

        public readonly ReactiveCommand<Unit, bool> ToggleBorrowBookCommand;

        public ReaderManageViewModel()
        {
            Items = Context.Readers.Local;
            this.ValidationRule(
                model => model.SelectedItem.Name,
                title => !string.IsNullOrWhiteSpace(title),
                "Name is required"
            );
            this.ValidationRule(
                model => model.SelectedItem.Limit,
                year => year > 0,
                "Year must > 0"
            );
            this.ValidationRule(
                model => model.SelectedItem.Gender,
                val => val != null,
                "Please select Gender"
            );
            this.ValidationRule(
                model => model.SelectedItem.Birth,
                val => val != null,
                "Please provide birth date"
            );
            this.ValidationRule(
                model => model.SelectedItem.Email,
                this.WhenAnyValue(model => model.SelectedItem.Email)
                    .Select(ValidateEmail)
            );
            this.ValidationRule(
                model => model.SelectedItem.PhoneNumber,
                this.WhenAnyValue(model => model.SelectedItem.PhoneNumber)
                    .Select(ValidatePhone)
            );

            var isSelected = this.WhenAnyValue(model => model.IsUpdating);
            ToggleBorrowBookCommand =
                ReactiveCommand.Create(() => ShowBorrowBookDialog = !ShowBorrowBookDialog, isSelected);
        }

        private static ValidationState ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return new ValidationState(false, "Email is required");
            }

            var emailRegex = new Regex(".+@.+");
            return !emailRegex.IsMatch(email)
                ? new ValidationState(false, "Invalid email format")
                : ValidationState.Valid;
        }

        private static ValidationState ValidatePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                return new ValidationState(false, "Phone is required");
            }

            var phoneRegex = new Regex("0[0-9]{9,10}");
            return !phoneRegex.IsMatch(phone)
                ? new ValidationState(false, "Invalid phone number format")
                : ValidationState.Valid;
        }

        protected override void OnSaving()
        {
            if (Context.Readers.Any(reader =>
                reader.Id != SelectedItem.Id && reader.PhoneNumber == SelectedItem.PhoneNumber))
            {
                throw new Exception("Phone number was already taken");
            }

            if (Context.Readers.Any(reader =>
                reader.Id != SelectedItem.Id && reader.Email == SelectedItem.Email))
            {
                throw new Exception("Email was already taken");
            }
        }

        protected override void OnDeleting()
        {
            if (SelectedItem.Tickets.Any(ticket => ticket.ReturnedDate is null))
            {
                throw new Exception("User is borrowing some book");
            }
        }
    }
}