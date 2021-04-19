namespace LibraryApplication.UI.View.App
{
    public partial class LoginForm : NavigateForm
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
            btnLogin.Click += (_, _) =>
            {
                txtUserName.Error = string.IsNullOrEmpty(txtUserName.Value) ? "Please enter username" : "";
                txtPassword.Error = string.IsNullOrEmpty(txtPassword.Value) ? "Please enter password" : "";
                if (txtUserName.Error != "" || txtPassword.Error != "") return;

                if (txtUserName.Value != "admin" || txtPassword.Value != "admin")
                {
                    txtPassword.Error = "Wrong username or password";
                    return;
                }

                txtPassword.Error = "";
                NavigateTo(new AppView());
            };
        }
    }
}