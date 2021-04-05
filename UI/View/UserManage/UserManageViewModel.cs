using ReactiveUI;
using Splat;

namespace WinFormsLibraryManager.UI.View.UserManage
{
    public class UserManageViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "UserManage";

        public IScreen HostScreen { get; }

        public UserManageViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
}