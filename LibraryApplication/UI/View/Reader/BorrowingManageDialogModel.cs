using ReactiveUI;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;

namespace LibraryApplication.UI.View.Reader
{
    public class BorrowingManageDialogModel : ReactiveObject, IValidatableViewModel
    {
        private Model.Book.Reader Reader { get; }
        public ValidationContext ValidationContext { get; } = new();

        public BorrowingManageDialogModel(Model.Book.Reader reader)
        {
            Reader = reader;
        }
    }
}