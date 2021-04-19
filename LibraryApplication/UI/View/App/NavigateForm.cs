using System;
using MaterialSkin;
using MaterialSkin.Controls;
using Splat;

namespace LibraryApplication.UI.View.App
{
    public class NavigateForm : MaterialForm
    {
        private readonly MainForm _main;
        private readonly MaterialSkinManager _skinManager;

        protected NavigateForm()
        {
            _skinManager = MaterialSkinManager.Instance;
            _main = Locator.Current.GetService<MainForm>();

            _skinManager.AddFormToManage(this);
            Closed += OnClose;
        }

        protected void NavigateTo(NavigateForm form)
        {
            Closed -= OnClose;
            _skinManager.RemoveFormToManage(this);
            _main.Show(form);
        }

        private void OnClose(object sender, EventArgs args)
        {
            _main.Shutdown();
        }
    }
}