using CrosshairX.ViewModels.General;
using System.Windows.Input;

namespace CrosshairX.ViewModels;

public class HomeViewModel : ObservableByProperty
{
    public ICommand SwitchLanguageCommand { get; set; }

    public HomeViewModel()
    {
        SwitchLanguageCommand = new RelayCommand(ToEnglish);
    }

    public void ToEnglish()
    {
        Localizer.ToEnglish();
        SwitchLanguageCommand = new RelayCommand(ToUkrainian);
    }

    public void ToUkrainian()
    {
        Localizer.ToUkrainian();
        SwitchLanguageCommand = new RelayCommand(ToEnglish);
    }
}