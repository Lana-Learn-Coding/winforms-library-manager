using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LibraryApplication.Model.Book;

namespace LibraryApplication.UI.Component.Table
{
    public partial class BookListControl : UserControl
    {
        private BindingList<BookItem> _dataSource;

        public BindingList<BookItem> DataSource
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

        public BookListControl()
        {
            InitializeComponent();
            table.BorderStyle = BorderStyle.FixedSingle;
            table.Columns.AddRange(new ColumnHeader[]
            {
                new() {Text = "Id", Width = 60},
                new() {Text = "Title", Width = 200}
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
                .Select(bookItem => { return new[] {bookItem.Id.ToString(), bookItem.BookMeta.Title}; })
                .Select(item => new ListViewItem(item))
                .ToArray();
            table.Items.AddRange(items);
        }
    }
}