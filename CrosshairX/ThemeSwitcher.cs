using Windows.UI.Xaml;

namespace CrosshairX;

public static class ThemeSwitcher
{
    public static void Switch()
    {
        To(Application.Current.RequestedTheme == ApplicationTheme.Light
            ? ApplicationTheme.Dark
            : ApplicationTheme.Light);
    }

    public static void To(ApplicationTheme theme)
    {
        Application.Current.RequestedTheme = theme;
    }
}