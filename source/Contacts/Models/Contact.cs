namespace Contacts.Models;

/// <summary>
/// Представляет контакт.
/// </summary>
public class Contact
{
    /// <summary>
    /// Возвращает или задает значение имени контакта.
    /// </summary>
    public string Name { get; set; } = "";

    /// <summary>
    /// Возвращает или задает значение номер телефона.
    /// </summary>
    public string PhoneNumber { get; set; } = "";

    /// <summary>
    /// Возвращает или задает значение адрес электронной почты.
    /// </summary>
    public string Email { get; set; } = "";
}