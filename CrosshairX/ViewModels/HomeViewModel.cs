using System.Windows.Input;
using CrosshairX.ViewModels.General;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace CrosshairX.ViewModels;

public class HomeViewModel : ObservableByProperty
{
    public ICommand SetCursorCommand { get; set; }
    public ICommand ReturnCursorCommand { get; set; }

    public HomeViewModel()
    {
        SetCursorCommand = new RelayCommand(SetCursor);
        ReturnCursorCommand = new RelayCommand(ReturnCursor);
    }

    public void SetCursor()
    {
        Localizer.ToEnglish();
    }

    public void ReturnCursor()
    {
        Localizer.ToUkrainian();
    }
}