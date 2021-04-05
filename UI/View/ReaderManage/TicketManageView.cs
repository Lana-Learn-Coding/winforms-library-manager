using System.Windows.Forms;
using ReactiveUI;

namespace WinFormsLibraryManager.UI.View.ReaderManage
{
    public partial class TicketManageView : Form, IViewFor<TicketManageViewModel>
    {
        public TicketManageView()
        {
            InitializeComponent();
        }

        public TicketManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TicketManageViewModel) value;
        }
    }
}