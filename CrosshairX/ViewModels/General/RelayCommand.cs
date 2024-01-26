using System;
using System.Windows.Input;

namespace CrosshairX.ViewModels.General;

public class RelayCommand<TParameter> : ICommand
{
    private readonly Action<TParameter?> _executeAction;
    private readonly Predicate<TParameter?>? _canExecuteAction;

    public event EventHandler? CanExecuteChanged;
    
    public RelayCommand(Action<TParameter?> executeAction, Predicate<TParameter?>? canExecuteAction = null)
    {
        _executeAction = executeAction;
        _canExecuteAction = canExecuteAction;
    }

    public bool CanExecute(object parameter)
    {
        if (parameter == null) throw new ArgumentNullException(nameof(parameter));
        return _canExecuteAction?.Invoke((TParameter)parameter) ?? true;
    }

    public void Execute(object parameter)
    {
        if (parameter == null) throw new ArgumentNullException(nameof(parameter));
        _executeAction((TParameter)parameter);
    }
}

public class RelayCommand : ICommand
{
    private readonly Action _executeAction;
    private readonly Predicate<object>? _canExecuteAction;

    public event EventHandler? CanExecuteChanged;
    
    public RelayCommand(Action executeAction, Predicate<object>? canExecuteAction = null)
    {
        _executeAction = executeAction;
        _canExecuteAction = canExecuteAction;
    }

    public bool CanExecute(object parameter)
    {
        return _canExecuteAction?.Invoke(parameter) ?? true;
    }

    public void Execute(object parameter)
    {
        _executeAction();
    }
}