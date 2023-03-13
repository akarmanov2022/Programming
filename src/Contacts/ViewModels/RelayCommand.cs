using System;
using System.Windows.Input;

namespace Contacts.ViewModels;

/// <summary>
/// Определяет релейную команду.
/// </summary>
/// <typeparam name="T">Тип данных объектов, переданных команде на исполнение.</typeparam>
public class RelayCommand<T> : ICommand
{
    /// <summary>
    /// Инкапсулирует метод для исполнения командой при вызове.
    /// </summary>
    private readonly Action<T> _execute;

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="execute">Метод, который имеет один параметр и не возвращает значение.</param>
    public RelayCommand(Action<T> execute)
    {
        _execute = execute;
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter == null) return;
        _execute.Invoke((T)parameter);
    }

    public event EventHandler? CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}