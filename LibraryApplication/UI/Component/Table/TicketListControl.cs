using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LibraryApplication.Model.Book;

namespace LibraryApplication.UI.Component.Table
{
    public partial class TicketListControl : UserControl
    {
        private BindingList<Ticket> _dataSource;

        public BindingList<Ticket> DataSource
        {
            get => _dataSource;
            set
            {
                if (_dataSource != null)
                {
                    table.Items.Clear();
                    _dataSource.ListChanged -= OnListChanged;
                }

                if (value == null) return;
                _dataSource = value;
                _dataSource.ListChanged += OnListChanged;
                RefreshItems();
            }
        }

        public TicketListControl()
        {
            InitializeComponent();
            table.BorderStyle = BorderStyle.FixedSingle;
            table.Columns.AddRange(new ColumnHeader[]
            {
                new() {Text = "Ticket", Width = 318}
            });
        }

        private void OnListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshItems();
        }

        private void RefreshItems()
        {
            table.Items.Clear();
            var items = _dataSource
                .Select(item => new ListViewItem(item.ToString()))
                .ToArray();
            table.Items.AddRange(items);
        }
    }
}