using System.Drawing;
using System.Windows.Forms;
using LibraryApplication.UI.View.App;

namespace LibraryApplication.UI.View
{
    public partial class MainForm : Form
    {
        private NavigateForm CurrentForm { get; set; }

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Visible = false;
            Opacity = 0;
            Size = new Size(0, 0);
            ShowInTaskbar = false;
        }

        public void Show(NavigateForm nextForm)
        {
            nextForm.Show(this);
            CurrentForm?.Hide();
            CurrentForm = nextForm;
        }

        public void Shutdown()
        {
            CurrentForm.Hide();
            Close();
            Application.Exit();
        }
    }
}