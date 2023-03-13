namespace Contacts.Models;

/// <summary>
/// Представляет объект - контакт.
/// </summary>
public class Contact
{
    /// <summary>
    /// Возвращает или задает значение имени контакта.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Возвращает или задает значение номера.
    /// </summary>
    public string PhoneNumber { get; set; } = "";

    /// <summary>
    /// Возвращает или задает значение адреса электронной почты.
    /// </summary>
    public string Email { get; set; } = "";
}