using System.Windows.Forms;
using ReactiveUI;

namespace WinFormsLibraryManager.UI.View.User
{
    public partial class UserManageView : UserControl, IViewFor<UserManageViewModel>
    {
        public UserManageView()
        {
            InitializeComponent();
        }

        public UserManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (UserManageViewModel) value;
        }
    }
}