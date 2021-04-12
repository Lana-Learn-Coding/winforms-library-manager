using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class NumericControl : UserControl, INotifyPropertyChanged
    {
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

        private int? _number;

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int? Value
        {
            get => _number;
            set
            {
                if (value == null)
                {
                    textBox.Text = "";
                    _number = null;
                    return;
                }

                textBox.Text = value.ToString();
                _number = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public NumericControl()
        {
            InitializeComponent();
            textBox.TextChanged += (_, _) =>
            {
                try
                {
                    _number = int.Parse(textBox.Text);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
                catch (Exception e)
                {
                    if (_number == null)
                    {
                        textBox.Text = "";
                        return;
                    }

                    textBox.Text = _number.ToString();
                }
            };
        }
    }
}