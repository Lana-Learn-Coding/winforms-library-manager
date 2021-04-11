using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryApplication.UI.Component
{
    public partial class NumericControl : UserControl
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

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public NumericControl()
        {
            InitializeComponent();
        }
    }
}