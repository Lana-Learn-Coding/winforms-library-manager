using System.Windows.Forms;
using ReactiveUI;

namespace WinFormsLibraryManager.UI.View.BookManage
{
    public partial class BookManageView : Form, IViewFor<BookManageViewModel>
    {
        public BookManageView()
        {
            InitializeComponent();
        }

        public BookManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BookManageViewModel) value;
        }
    }
}