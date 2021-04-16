using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component.Table
{
    public class DataGridViewFormattedColumn : DataGridViewTextBoxColumn
    {
        [DefaultValue("")]
        [Category("Behavior")]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public string Format
        {
            get => DefaultCellStyle.Format;
            set => DefaultCellStyle.Format = value;
        }
    }
}