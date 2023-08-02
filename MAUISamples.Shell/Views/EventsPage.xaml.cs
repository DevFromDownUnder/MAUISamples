namespace MAUISamples.Shell.Views
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();

            Title = "Calendar";
        }

        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Microsoft.Maui.Controls.Shell.Current.GoToAsync("newevent");
        }
    }
}
