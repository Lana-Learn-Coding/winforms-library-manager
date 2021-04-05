using ReactiveUI;
using Splat;

namespace WinFormsLibraryManager.UI.View.ReaderManage
{
    public class TicketManageViewModel : ReactiveObject, IRoutableViewModel
    {
        public string UrlPathSegment => "TicketManage";

        public IScreen HostScreen { get; }

        public TicketManageViewModel(IScreen screen = null)
        {
            HostScreen = screen ?? Locator.Current.GetService<IScreen>();
        }
    }
}