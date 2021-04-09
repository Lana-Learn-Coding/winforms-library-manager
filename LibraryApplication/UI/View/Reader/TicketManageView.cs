using System.Windows.Forms;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class TicketManageView : UserControl, IViewFor<TicketManageViewModel>
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