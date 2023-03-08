using System;
using System.Windows.Input;

namespace Contacts.ViewModels;

public class LoadCommand : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        // throw new NotImplementedException();
    }

    public event EventHandler? CanExecuteChanged;
}