using System.Reactive.Disposables;
using MaterialSkin;
using MaterialSkin.Controls;
using ReactiveUI;

namespace WinFormsLibraryManager.UI
{
    public partial class AppView : MaterialForm, IViewFor<AppViewModel>
    {
        public AppView()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo100,
                Accent.Pink200,
                TextShade.WHITE
            );

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