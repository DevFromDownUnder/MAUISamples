namespace MAUISamples.Shell
{
    public partial class AppShell : Microsoft.Maui.Controls.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register the routes of the detail pages
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("newevent", typeof(NewEventPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
    }
}
