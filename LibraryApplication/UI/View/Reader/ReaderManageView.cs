﻿using System.Windows.Forms;
using ReactiveUI;

namespace LibraryApplication.UI.View.Reader
{
    public partial class ReaderManageView : UserControl, IViewFor<ReaderManageViewModel>
    {
        public ReaderManageView()
        {
            InitializeComponent();
        }

        public ReaderManageViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ReaderManageViewModel) value;
        }
    }
}