using System.Reactive.Disposables;
using System.Windows.Forms;
using ReactiveUI;

namespace WinFormsLibraryManager.UI
{
    public partial class AppView : Form, IViewFor<AppViewModel>
    {
        public AppView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, model => model.Router, view => view.routedControlHost.Router)
                    .DisposeWith(disposables);

                this.OneWayBind(ViewModel, model => model.ApplicationTitle, view => view.Text)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, model => model.ShowBookManageCommand, view => view.btnBookManage)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, model => model.ShowReaderManageCommand, view => view.btnReaderManage)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, model => model.ShowTicketManageCommand, view => view.btnTicketManage)
                    .DisposeWith(disposables);

                this.BindCommand(ViewModel, model => model.ShowUserManageCommand, view => view.btnUserManage)
                    .DisposeWith(disposables);
            });
        }

        public AppViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AppViewModel) value;
        }
    }
}