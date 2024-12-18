#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Views;
using Windows.Graphics;
#endif

namespace FortuneWheelApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}