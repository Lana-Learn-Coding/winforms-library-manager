using ReactiveUI;
using Splat;

namespace WinFormsLibraryManager.UI.View.BookManage
{
    public class BookManageViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "BookManage";

        public IScreen HostScreen { get; }

        public BookManageViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
}