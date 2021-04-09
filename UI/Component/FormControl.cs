using System.Windows.Forms;

namespace WinFormsLibraryManager.UI.Component
{
    public partial class FormControl : UserControl
    {
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public FormControl()
        {
            InitializeComponent();
        }
    }
}