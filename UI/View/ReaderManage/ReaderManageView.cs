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

namespace WinFormsLibraryManager.UI.View.ReaderManage
{
    public partial class ReaderManageView : Form, IViewFor<ReaderManageViewModel>
    {
        public ReaderManageView()
        {
            InitializeComponent();
        }

        public ReaderManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ReaderManageViewModel) value;
        }
    }
}