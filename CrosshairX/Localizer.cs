using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace CrosshairX
{
    public static class Localizer
    {
        public static void ToUkrainian()
        {
            To("uk-UA");
        }

        public static void ToEnglish()
        {
            To("en-US");
        }

        public static void To(string language)
        {
            Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = language;
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();

            if (Window.Current.Content is Frame frame)
            {
                frame.CacheSize = 0;
                frame.Navigate(typeof(Layout));
            }
        }
    }
}
