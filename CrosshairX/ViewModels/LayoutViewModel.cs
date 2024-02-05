using CrosshairX.ViewModels.General;
using CrosshairX.Views;
using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace CrosshairX.ViewModels
{
    public class LayoutViewModel : ObservableByProperty
    {
        private Frame _rootFrame = null!;

        public Frame RootFrame
        {
            get => _rootFrame;
            set => SetField(ref _rootFrame, value);
        }

        public ICommand NavigateCommand { get; set; }
        public ICommand SwitchLanguageCommand { get; set; }

        public LayoutViewModel()
        {
            RootFrame = new Frame();
            RootFrame.Navigate(typeof(HomePage));
            NavigateCommand = new RelayCommand<Type>(NavigateTo);
            SwitchLanguageCommand = new RelayCommand(Localizer.SwitchLanguage);
        }

        public void NavigateTo(Type? pageType)
        {
            if (pageType == null)
                throw new ArgumentNullException(nameof(pageType));

            RootFrame.Navigate(pageType);
        }
    }
}
