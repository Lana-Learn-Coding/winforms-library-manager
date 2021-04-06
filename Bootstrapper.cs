using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using ReactiveUI;
using Splat;
using WinFormsLibraryManager.UI;

namespace WinFormsLibraryManager
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {
            ConfigureServices();
        }

        private void ConfigureServices()
        {
            // Make sure Splat and ReactiveUI are already configured in the locator
            // so that our override runs last
            Locator.CurrentMutable.InitializeSplat();
            Locator.CurrentMutable.InitializeReactiveUI();

            Locator.CurrentMutable.RegisterLazySingleton(() => new ConventionalViewLocator(), typeof(IViewLocator));
            Locator.CurrentMutable.RegisterConstant(MaterialSkinManager.Instance, typeof(MaterialSkinManager));
        }

        public void Run()
        {
            var viewModel = new AppViewModel();
            Locator.CurrentMutable.RegisterConstant(viewModel, typeof(IAppViewModel));

            var view = ViewLocator.Current.ResolveView(viewModel);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage((MaterialForm) view);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo100,
                Accent.Pink200,
                TextShade.WHITE
            );

            view.ViewModel = viewModel;
            Application.Run((Form) view);
        }
    }
}