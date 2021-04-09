using System.Reactive.Disposables;
using MaterialSkin.Controls;
using ReactiveUI;

namespace WinFormsLibraryManager.UI
{
    public partial class AppView : MaterialForm, IViewFor<AppViewModel>
    {
        public AppView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, model => model.ApplicationTitle, view => view.Text)
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