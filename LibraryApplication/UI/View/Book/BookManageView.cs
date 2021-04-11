using System.ComponentModel;
using System.Windows.Forms;
using ReactiveUI;

namespace LibraryApplication.UI.View.Book
{
    public partial class BookManageView : UserControl, IViewFor<BookManageViewModel>
    {
        public BookManageView()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BookManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (BookManageViewModel) value;
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            var rowsCount = table.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = table.SelectedRows[0];
            if (row == null) return;
            var id = row.Cells["ID"].Value.ToString() ?? "0";
            ViewModel.OnRowSelected(int.Parse(id));
        }
    }
}