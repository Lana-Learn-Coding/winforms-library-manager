using System.Data.Entity;
using System.Windows.Forms;
using LibraryApplication.Model;
using LibraryApplication.UI;
using MaterialSkin;
using MaterialSkin.Controls;
using ReactiveUI;
using Splat;

namespace LibraryApplication
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {
            ConfigureServices();
        }

        private static void ConfigureServices()
        {
            // Make sure Splat and ReactiveUI are already configured in the locator
            // so that our override runs last
            Locator.CurrentMutable.InitializeSplat();
            Locator.CurrentMutable.InitializeReactiveUI();

            Locator.CurrentMutable.RegisterLazySingleton(() => new ConventionalViewLocator(), typeof(IViewLocator));
            Locator.CurrentMutable.RegisterConstant(MaterialSkinManager.Instance, typeof(MaterialSkinManager));


            // Initialize database
            var modelContext = new ModelContext();
            Locator.CurrentMutable.RegisterConstant(modelContext, typeof(ModelContext));
            modelContext.Authors.Load();
            modelContext.Series.Load();
            modelContext.Storages.Load();
            modelContext.Categories.Load();
            modelContext.Publishers.Load();
            modelContext.Users.Load();
            modelContext.Books.Load();
            modelContext.BookItems.Load();
            modelContext.Permissions.Load();
            modelContext.Tickets.Load();
            modelContext.Readers.Load();
            modelContext.Positions.Load();
            modelContext.Genders.Load();
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