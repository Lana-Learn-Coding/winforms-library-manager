using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLibraryManager.UI
{
    public partial class AppView : Form, IViewFor<AppViewModel>
    {
        public AppView()
        {
            InitializeComponent();
        }

        public AppViewModel ViewModel { get; set; }

        object IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AppViewModel)(value); }
    }
}
