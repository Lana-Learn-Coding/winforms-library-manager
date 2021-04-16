using System;
using System.ComponentModel;

namespace LibraryApplication.UI.Component.Table
{
    public class DataGridViewDateTimeColumn : DataGridViewFormattedColumn
    {
        [DefaultValue("yyyy-MM-dd HH:mm:ss")]
        [Category("Behavior")]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public new string Format
        {
            get => base.Format;
            set => base.Format = value;
        }

        public DataGridViewDateTimeColumn()
        {
            Format = "yyyy-MM-dd HH:mm:ss";
            ValueType = typeof(DateTime?);
        }
    }
}