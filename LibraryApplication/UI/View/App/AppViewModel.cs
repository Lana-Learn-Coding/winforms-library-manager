using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI.View.App
{
    public class AppViewModel : ReactiveObject
    {
        [Reactive] public string ApplicationTitle { get; set; }

        public AppViewModel()
        {
            ApplicationTitle = "LibMan - Library Manage Application";
        }
    }
}