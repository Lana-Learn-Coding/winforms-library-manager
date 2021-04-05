using ReactiveUI;
using Splat;

namespace WinFormsLibraryManager.UI.View.ReaderManage
{
    public class ReaderManageViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "ReaderManage";

        public IScreen HostScreen { get; }

        public ReaderManageViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
}