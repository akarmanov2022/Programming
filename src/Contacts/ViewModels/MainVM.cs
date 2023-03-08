using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Contacts.Models;

namespace Contacts.ViewModels;

/// <summary>
/// Привет
/// </summary>
public sealed class MainVM : INotifyPropertyChanged
{
    public Contact Contact { get; } = new();

    public string Name
    {
        get => Contact.Name;
        set
        {
            if (value == Contact.Name) return;
            Contact.Name = value;
            OnPropertyChanged();
        }
    }

    public string PhoneNumber
    {
        get => Contact.PhoneNumber;
        set
        {
            if (value == Contact.PhoneNumber) return;
            Contact.PhoneNumber = value;
            OnPropertyChanged();
        }
    }

    public string Email
    {
        get => Contact.Email;
        set
        {
            if (value == Contact.Email) return;
            Contact.Email = value;
            OnPropertyChanged();
        }
    }


    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}