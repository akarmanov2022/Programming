using System;
using System.Windows.Input;
using Contacts.Models;
using Contacts.Models.Services;

namespace Contacts.ViewModels;

public class SaveCommand : ICommand
{
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter is not Contact contact) return;
        Serializer<Contact>.ToJson(contact, "Contact\\contact.json");
    }

    public event EventHandler? CanExecuteChanged;
}