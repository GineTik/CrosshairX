using Windows.UI.Xaml.Controls;
using CrosshairX.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace CrosshairX.Views
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            //DataContext = new HomeViewModel(); //App.Services.GetRequiredService<HomeViewModel>();
        }
    }
}
