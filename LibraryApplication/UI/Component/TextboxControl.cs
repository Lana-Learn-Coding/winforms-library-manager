using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class TextboxControl : UserControl, INotifyPropertyChanged
    {
        [Description("Hint of the textbox"), Category("Material Skin")]
        public string Hint
        {
            get => textBox.Hint;
            set => textBox.Hint = value;
        }

        [Description("Enable"), Category("Material Skin")]
        public bool Enabled
        {
            get => textBox.Enabled;
            set => textBox.Enabled = value;
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

        public string Value
        {
            get => textBox.Text ?? "";
            set => textBox.Text = value ?? "";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public TextboxControl()
        {
            InitializeComponent();
            textBox.TextChanged += (_, _) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
        }
    }
}