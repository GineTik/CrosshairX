using CrosshairX.ViewModels.General;
using CrosshairX.Views;
using System;
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

        public RelayCommand<Type> NavigateCommand { get; set; }

        public LayoutViewModel()
        {
            RootFrame = new Frame();
            RootFrame.Navigate(typeof(CommunityPage));
            NavigateCommand = new RelayCommand<Type>(NavigateTo);
        }

        public void NavigateTo(Type? pageType)
        {
            if (pageType == null)
                throw new ArgumentNullException(nameof(pageType));

            RootFrame.Navigate(pageType);
        }
    }
}
