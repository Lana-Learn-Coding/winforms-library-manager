using System.ComponentModel;
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

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TicketManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (TicketManageViewModel) value;
        }
    }
}