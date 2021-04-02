using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Locator.CurrentMutable.RegisterLazySingleton(() => new ConventionalViewLocator(), typeof(IViewLocator));
        }

        public void Run()
        {
            var viewModel = new AppViewModel();
            var view = ViewLocator.Current.ResolveView(viewModel);
            view.ViewModel = viewModel;
            Application.Run((Form)view);
        }
    }
}
