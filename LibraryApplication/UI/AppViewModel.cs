﻿using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace LibraryApplication.UI
{
    public class AppViewModel : ReactiveObject, IAppViewModel
    {
        [Reactive] public string ApplicationTitle { get; set; }

        public AppViewModel()
        {
            ApplicationTitle = "LibMan - Library Manage Application";
        }
    }
}