using CrosshairX.ViewModels;
using Windows.UI.Xaml.Controls;

namespace CrosshairX.Views
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            DataContext = new HomeViewModel(); //App.Services.GetRequiredService<HomeViewModel>();
        }
    }
}
