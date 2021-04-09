using System.Windows.Forms;
using ReactiveUI;

namespace WinFormsLibraryManager.UI.View.Book
{
    public partial class BookManageView : UserControl, IViewFor<BookManageViewModel>
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