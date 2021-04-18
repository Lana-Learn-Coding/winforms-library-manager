using LibraryApplication.Model;
using ReactiveUI;
using Splat;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();
        protected ModelContext Context { get; }
        protected Model.Book.Reader Reader { get; }

        public BorrowingManageDialogModel(Model.Book.Reader reader)
        {
            Reader = reader;
            Context = Locator.Current.GetService<ModelContext>();
            InitializeNewTicketTab();
            InitializeBorrowManageTab();
        }
    }
}