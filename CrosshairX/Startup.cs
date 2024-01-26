using Windows.UI.Xaml;
using CrosshairX.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace CrosshairX;

public static class Startup
{
    public static void ConfigureServiceCollection(IServiceCollection services)
    {
        services.AddSingleton<HomeViewModel>();
    }

    public static void SetCobTheme(ApplicationTheme userTheme)
    {
        ThemeSwitcher.To(userTheme);
    }
}