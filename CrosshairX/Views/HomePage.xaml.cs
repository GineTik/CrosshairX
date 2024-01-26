using Windows.UI.Xaml.Controls;
using CrosshairX.ViewModels;
using Microsoft.Extensions.DependencyInjection;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace CrosshairX.Views
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            DataContext = App.Services.GetRequiredService<HomeViewModel>();
        }
    }
}
