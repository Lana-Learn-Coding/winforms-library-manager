using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class BookListControl : UserControl
    {
        public BookListControl()
        {
            InitializeComponent();
            table.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}