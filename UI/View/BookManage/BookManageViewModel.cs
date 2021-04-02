using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
