using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReactiveUI;

namespace WinFormsLibraryManager.UI.View.UserManage
{
    public partial class UserManageView : Form, IViewFor<UserManageViewModel>
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