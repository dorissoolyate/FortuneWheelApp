#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Views;
using Windows.Graphics;
#endif

namespace FortuneWheelApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Создаем стартовую страницу и оборачиваем ее в NavigationPage
        MainPage = new NavigationPage(new Views.WelcomePage());
    }
}
