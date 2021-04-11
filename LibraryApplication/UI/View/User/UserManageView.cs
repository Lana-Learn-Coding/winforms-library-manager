using System.ComponentModel;
using System.Windows.Forms;
using ReactiveUI;

namespace LibraryApplication.UI.View.User
{
    public partial class UserManageView : UserControl, IViewFor<UserManageViewModel>
    {
        public UserManageView()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (UserManageViewModel) value;
        }
    }
}