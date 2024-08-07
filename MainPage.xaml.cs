namespace MyFirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void aumentar(object sender, EventArgs e)
        {
            count++;


            if (count == 1)
                ClicksLabel.Text = $"Clicks: {count}";
            else
                ClicksLabel.Text = $"Clicks: {count}";

            SemanticScreenReader.Announce(ClicksLabel.Text);
        }
        private void diminuir(object sender, EventArgs e) {
            count--;

            if (count == 1)
                ClicksLabel.Text = $"Clicks: {count}";
            else
                ClicksLabel.Text = $"Clicks: {count}";
        }

        private void goToPageOne(object sender, EventArgs e) {
            Navigation.PushAsync(new NewPage1());
        }
    }

}
