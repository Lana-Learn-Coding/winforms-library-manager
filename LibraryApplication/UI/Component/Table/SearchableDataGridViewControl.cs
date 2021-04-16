using System;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component.Table
{
    public partial class SearchableDataGridViewControl : UserControl
    {
        public DataGridView Grid
        {
            get => grid;
            set => grid = value;
        }

        public SearchableDataGridViewControl()
        {
            InitializeComponent();
            grid.CellFormatting += (_, e) =>
            {
                if (grid.Rows[e.RowIndex].DataBoundItem != null &&
                    grid.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
                {
                    e.Value = BindProperty(
                        grid.Rows[e.RowIndex].DataBoundItem,
                        grid.Columns[e.ColumnIndex].DataPropertyName
                    );
                }
            };
        }

        private static string BindProperty(object property, string propertyName)
        {
            var retValue = "";

            if (propertyName.Contains("."))
            {
                var leftPropertyName = propertyName[..propertyName.IndexOf(".", StringComparison.Ordinal)];
                var arrayProperties = property.GetType().GetProperties();

                foreach (var propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name != leftPropertyName) continue;
                    retValue = BindProperty(propertyInfo.GetValue(property, null),
                        propertyName[(propertyName.IndexOf(".", StringComparison.Ordinal) + 1)..]);
                    break;
                }
            }
            else
            {
                var propertyType = property.GetType();
                var propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }

            return retValue;
        }
    }
}