using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Contacts.Models;
using Contacts.Services;

namespace Contacts.ViewModels;

/// <summary>
/// VM для главного окна.
/// </summary>
public sealed class MainVm : INotifyPropertyChanged
{

    /// <summary>
    /// Инкапулирует экземпляр текущего объекта типа <see cref="Contact"/>.
    /// </summary>
    private Contact _contact;

    /// <summary>
    /// Инкапулирует команду <see cref="ICommand"/> на сохранение объекта типа <see cref="Contact"/> в файл.
    /// </summary>
    private RelayCommand<Contact>? _saveCommand;

    /// <summary>
    /// Инкапулирует команду <see cref="ICommand"/> на загрузку объекта типа <see cref="Contact"/> из файла. 
    /// </summary>
    private RelayCommand<Contact>? _loadCommand;

    /// <summary>
    /// Конструктор по-умолчанию.
    /// </summary>
    /// <param name="contact">Объект типа <see cref="Contact"/></param>
    public MainVm(Contact contact)
    {
        _contact = contact;
    }

    /// <summary>
    /// Возвращает или задает экземпляр объекта типа <see cref="Contact"/>. 
    /// </summary>
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

    /// <summary>
    /// Возвращает или задает имя контакта. 
    /// </summary>
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

    /// <summary>
    /// Возвращает или задает номер телефона. 
    /// </summary>
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

    /// <summary>
    /// Возвращает или задает значение адреса электронной почты.
    /// </summary>
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

    /// <summary>
    /// Возвращает экземпляр команды <see cref="ICommand"/> на сохранение объекта типа <see cref="Contact"/> в файл.
    /// </summary>
    public RelayCommand<Contact> SaveCommand => _saveCommand ??= 
        new RelayCommand<Contact>(contact =>
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Serializer<Contact>.ToJson(contact, Path.Combine(folderPath, "Contacts", "save.json"));
            MessageBox.Show(
                "The contact is saved!", "Info", 
                MessageBoxButton.OK, MessageBoxImage.Information);
        });

    /// <summary>
    /// Возвращает экземпляр команды <see cref="ICommand"/> на загрузку объекта типа <see cref="Contact"/> из файла.
    /// </summary>
    public RelayCommand<Contact> LoadCommand => _loadCommand ??=
        new RelayCommand<Contact>(_ =>
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Contact = Serializer<Contact>.FromJson(Path.Combine(folderPath, "Contacts", "save.json"));
        });
    
    /// <inheritdoc />
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Вызов события изменения значения свойства.
    /// </summary>
    /// <param name="propertyName">Название свойства.</param>
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}