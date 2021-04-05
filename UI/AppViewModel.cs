using System;
using System.Reactive;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using WinFormsLibraryManager.UI.View.BookManage;
using WinFormsLibraryManager.UI.View.ReaderManage;
using WinFormsLibraryManager.UI.View.UserManage;

namespace WinFormsLibraryManager.UI
{
    public class AppViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public AppViewModel()
        {
            Router = new RoutingState();

            ShowBookManageCommand = ReactiveCommand.CreateFromObservable(ShowBookManage);
            ShowReaderManageCommand = ReactiveCommand.CreateFromObservable(ShowReaderManage);
            ShowTicketManageCommand = ReactiveCommand.CreateFromObservable(ShowTicketManage);
            ShowUserManageCommand = ReactiveCommand.CreateFromObservable(ShowUserManage);

            ShowBookManage();
        }

        [Reactive] public string ApplicationTitle { get; private set; }

        public ReactiveCommand<Unit, IRoutableViewModel> ShowBookManageCommand { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ShowReaderManageCommand { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ShowTicketManageCommand { get; }
        public ReactiveCommand<Unit, IRoutableViewModel> ShowUserManageCommand { get; }


        private IObservable<IRoutableViewModel> ShowBookManage()
        {
            ApplicationTitle = "LibMan - Book Manage";
            return Router.Navigate.Execute(new BookManageViewModel());
        }

        private IObservable<IRoutableViewModel> ShowReaderManage()
        {
            ApplicationTitle = "LibMan - Reader Manage";
            return Router.Navigate.Execute(new ReaderManageViewModel());
        }

        private IObservable<IRoutableViewModel> ShowTicketManage()
        {
            ApplicationTitle = "LibMan - Ticket Manage";
            return Router.Navigate.Execute(new TicketManageViewModel());
        }

        private IObservable<IRoutableViewModel> ShowUserManage()
        {
            ApplicationTitle = "LibMan - User Manage";
            return Router.Navigate.Execute(new UserManageViewModel());
        }
    }
}