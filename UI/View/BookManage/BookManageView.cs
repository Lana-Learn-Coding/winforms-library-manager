using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLibraryManager.UI.View.BookManage
{
    public partial class BookManageView : Form, IViewFor<BookManageViewModel>
    {
        public BookManageView()
        {
            InitializeComponent();
        }

        public BookManageViewModel ViewModel { get; set; }
        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (BookManageViewModel)value; }
    }
}
