using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibraryManager.UI
{
    public class AppViewModel : ReactiveObject, IScreen
    {
        public RoutingState Router { get; }

        public AppViewModel()
        {
            // Initialize the Router.
            Router = new RoutingState();
            // Manage the routing state. Use the Router.Navigate.Execute
            // command to navigate to different view models. 
            //
            // Note, that the Navigate.Execute method accepts an instance 
            // of a view model, this allows you to pass parameters to 
            // your view models, or to reuse existing view models.
            //
            //GoNext = ReactiveCommand.CreateFromObservable(() => Router.Navigate.Execute(new FirstViewModel()));

            // You can also ask the router to go back.
            //GoBack = Router.NavigateBack;
        }
    }
}
