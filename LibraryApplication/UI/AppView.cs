﻿using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Forms;
using LibraryApplication.UI.View;
using MaterialSkin.Controls;
using ReactiveUI;

namespace LibraryApplication.UI
{
    public partial class AppView : MaterialForm, IViewFor<AppViewModel>
    {
        public AppView()
        {
            InitializeComponent();
            this.WhenActivated(disposables =>
            {
                this.OneWayBind(ViewModel, model => model.ApplicationTitle, view => view.Text)
                    .DisposeWith(disposables);

                mainTabControl.Events().SelectedIndexChanged
                    .Where(_ => mainTabControl.SelectedTab.Controls[0] is IDataFormView)
                    .Select(_ => mainTabControl.SelectedTab.Controls[0] as IDataFormView)
                    .Subscribe(form => { form.Table.Refresh(); })
                    .DisposeWith(disposables);
            });
        }

        public AppViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AppViewModel) value;
        }
    }
}