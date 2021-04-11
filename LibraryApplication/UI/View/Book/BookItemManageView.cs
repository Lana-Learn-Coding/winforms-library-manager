using System.ComponentModel;
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

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookItemManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BookItemManageViewModel) value;
        }
    }
}