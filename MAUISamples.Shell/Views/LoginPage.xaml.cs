namespace MAUISamples.Shell.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await Microsoft.Maui.Controls.Shell.Current.GoToAsync("//home");
        }
    }
}
