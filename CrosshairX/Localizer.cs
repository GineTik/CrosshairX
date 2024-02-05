using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace CrosshairX
{
    public static class Localizer
    {
        public static string UA => "uk-UA";
        public static string EN => "en-US";

        public static string CurrentLanguage { get; private set; } = UA;

        public static void SwitchLanguage()
        {
            if (CurrentLanguage == UA)
                ToEnglish();
            else
                ToUkrainian();
        }

        public static void ToUkrainian()
        {
            To(UA);
        }

        public static void ToEnglish()
        {
            To(EN);
        }

        public static void To(string language)
        {
            if (language != UA && language != EN)
                throw new ArgumentNullException("The language should be UA or EN");

            Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = language;
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForCurrentView().Reset();
            Windows.ApplicationModel.Resources.Core.ResourceContext.GetForViewIndependentUse().Reset();

            if (Window.Current.Content is Frame frame)
            {
                frame.CacheSize = 0;
                frame.Navigate(typeof(Layout));
                CurrentLanguage = language;
            }
        }
    }
}
