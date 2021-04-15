using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class DatePickerControl : UserControl, INotifyPropertyChanged
    {
        [Description("Enable"), Category("Material Skin")]
        public new bool Enabled
        {
            get => datePicker.Enabled;
            set
            {
                textBox.Enabled = value;
                datePicker.Enabled = value;
                contextMenuStrip.Enabled = value;
            }
        }

        [Description("Hint of the textbox"), Category("Material Skin")]
        public string Hint
        {
            get => textBox.Hint;
            set => textBox.Hint = value;
        }

        [Description("Error of the textbox"), Category("Material Skin")]
        public string Error
        {
            get => lblError.Text;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    textBox.UseAccent = false;
                    lblError.Text = "";
                    return;
                }

                lblError.Text = value;
                textBox.UseAccent = true;
            }
        }

        [Description("Label of the textbox"), Category("Material Skin")]
        public string Label
        {
            get => lbl.Text;
            set => lbl.Text = value;
        }

        [Description("Max date"), Category("Behaivour")]
        public DateTime MaxDate
        {
            get => datePicker.MaxDate;
            set => datePicker.MaxDate = value;
        }

        [Description("Min date"), Category("Behaivour")]
        public DateTime MinDate
        {
            get => datePicker.MinDate;
            set => datePicker.MinDate = value;
        }

        [Description("Format of the date"), Category("Behaivour"), DefaultValue("yyyy-MM-dd")]
        public string CustomFormat
        {
            get => datePicker.CustomFormat;
            set => datePicker.CustomFormat = value;
        }

        private DateTime? _value;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DateTime? Value
        {
            get => _value;
            set => SetDate(value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public DatePickerControl()
        {
            InitializeComponent();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd";
            datePicker.ValueChanged += (_, _) =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                textBox.Text = datePicker.Value.ToString(CustomFormat);
                _value = datePicker.Value;
            };
        }

        private void SetDate(DateTime? value)
        {
            if (value.HasValue)
            {
                datePicker.Value = value.Value;
                textBox.Text = datePicker.Value.ToString(CustomFormat);
                _value = value;
                return;
            }

            ClearDate();
        }

        private void ClearDate()
        {
            _value = null;
            datePicker.Value = DateTime.Now;
            textBox.Text = "";
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            datePicker.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void menuItemClear_Click(object sender, EventArgs e)
        {
            ClearDate();
        }
    }
}