using LibraryApplication.Model;
using ReactiveUI;
using Splat;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialogModel : ReactiveObject, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; } = new();
        private ModelContext ModelContext { get; }
        private Model.Book.Reader Reader { get; }

        public BorrowingManageDialogModel(Model.Book.Reader reader)
        {
            Reader = reader;
            ModelContext = Locator.Current.GetService<ModelContext>();
            InitializeNewTicketTab();
        }
    }
}