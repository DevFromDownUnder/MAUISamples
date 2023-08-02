namespace MAUISamples.Tab.Views
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();

        }

        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
    }
}
