using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class BorrowingManageDialog : MaterialForm, IViewFor<BorrowingManageDialogModel>
    {
        public BorrowingManageDialog(Model.Book.Reader reader)
        {
            InitializeComponent();
            ViewModel = new BorrowingManageDialogModel(reader);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BorrowingManageDialogModel) value;
        }

        public BorrowingManageDialogModel ViewModel { get; set; }
    }
}