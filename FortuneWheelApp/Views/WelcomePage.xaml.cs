namespace Views;



    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent(); // Эта строка вызывает генерацию всех элементов из XAML
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WheelPage());
        }
    }

