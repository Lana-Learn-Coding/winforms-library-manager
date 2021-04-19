using System.Data.Entity;
using System.Windows.Forms;
using LibraryApplication.Model;
using LibraryApplication.UI;
using LibraryApplication.UI.View;
using LibraryApplication.UI.View.App;
using MaterialSkin;
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
            modelContext.Categories.Load();
            modelContext.Publishers.Load();
            modelContext.Books.Load();

            modelContext.Positions.Load();
            modelContext.Storages.Load();
            modelContext.BookItems.Load();

            modelContext.Genders.Load();
            modelContext.Readers.Load();
            modelContext.Tickets.Load();

            modelContext.Permissions.Load();
            modelContext.Users.Load();
        }

        public void Run()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo100,
                Accent.Pink200,
                TextShade.WHITE
            );

            var form = new MainForm();
            Locator.CurrentMutable.RegisterConstant(form, typeof(MainForm));
            form.Show(new LoginForm());
            Application.Run(form);
        }
    }
}