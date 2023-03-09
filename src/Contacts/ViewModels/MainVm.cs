using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using Contacts.Models;
using Contacts.Models.Services;

namespace Contacts.ViewModels;

/// <summary>
/// Привет
/// </summary>
public sealed class MainVm : INotifyPropertyChanged
{

    private Contact _contact;

    private RelayCommand<Contact>? _saveCommand;

    private RelayCommand<Contact>? _loadCommand;

    public MainVm(Contact contact)
    {
        _contact = contact;
    }

    public Contact Contact
    {
        get => _contact;
        private set
        {
            if (Equals(value, _contact)) return;
            _contact = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(PhoneNumber));
            OnPropertyChanged(nameof(Email));
        }
    }

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

    public RelayCommand<Contact> SaveCommand => _saveCommand ??= 
        new RelayCommand<Contact>(contact =>
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Serializer<Contact>.ToJson(contact, Path.Combine(folderPath, "Contacts", "save.json"));
            MessageBox.Show(
                "The contact is saved!", "Info", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        });

    public RelayCommand<Contact> LoadCommand => _loadCommand ??=
        new RelayCommand<Contact>(_ =>
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Contact = Serializer<Contact>.FromJson(Path.Combine(folderPath, "Contacts", "save.json"));
        });

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}