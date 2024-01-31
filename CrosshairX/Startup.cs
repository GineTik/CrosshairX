using CrosshairX.ViewModels;
using CrosshairX.Views;
using Microsoft.Extensions.DependencyInjection;

namespace CrosshairX;

public static class Startup
{
    public static void ConfigureServiceCollection(IServiceCollection services)
    {
        services.AddSingleton<HomePage>();
        services.AddSingleton<CommunityPage>();
        services.AddSingleton<Layout>();

        services.AddSingleton<HomeViewModel>();
        services.AddSingleton<LayoutViewModel>();
    }
}