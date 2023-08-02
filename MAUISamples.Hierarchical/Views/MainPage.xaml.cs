namespace MAUISamples.Hierarchical.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
    }
}
