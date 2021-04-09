using System.Windows.Forms;
using ReactiveUI;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookItemManageView : UserControl, IViewFor<BookItemManageViewModel>
    {
        public BookItemManageView()
        {
            InitializeComponent();
        }

        public BookItemManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BookItemManageViewModel) value;
        }
    }
}