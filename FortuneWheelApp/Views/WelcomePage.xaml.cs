namespace Views;



    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent(); // ��� ������ �������� ��������� ���� ��������� �� XAML
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WheelPage());
        }
    }

