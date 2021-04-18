using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI.View.App
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

                mainTabControl.Events().SelectedIndexChanged
                    .Select(_ => mainTabControl.SelectedTab.Controls)
                    .Where(controls => controls.Count > 0 && controls[0] is IDataFormView)
                    .Select(controls => controls[0] as IDataFormView)
                    .Subscribe(form => { form.Table.Refresh(); })
                    .DisposeWith(disposables);
            });
        }

        public AppViewModel ViewModel { get; set; } = new();

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AppViewModel) value;
        }
    }
}