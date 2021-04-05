using System.Windows.Forms;
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
        }

        public void Run()
        {
            var viewModel = new AppViewModel();
            Locator.CurrentMutable.RegisterConstant(viewModel, typeof(IAppViewModel));

            var view = ViewLocator.Current.ResolveView(viewModel);
            view.ViewModel = viewModel;
            Application.Run((Form) view);
        }
    }
}