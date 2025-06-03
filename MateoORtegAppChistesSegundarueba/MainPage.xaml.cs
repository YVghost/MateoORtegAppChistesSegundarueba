namespace MateoORtegAppChistesSegundarueba
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAboutGridClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutGrid());
        }

        private async void OnAbsoluteLayoutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayout());
        }
    }

}
