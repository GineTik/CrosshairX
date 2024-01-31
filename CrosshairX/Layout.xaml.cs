using CrosshairX.ViewModels;
using Windows.UI.Xaml.Controls;

namespace CrosshairX
{
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            InitializeComponent();
            DataContext = new LayoutViewModel(); //App.Services.GetRequiredService<LayoutViewModel>();
        }
    }
}
