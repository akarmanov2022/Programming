using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static Programming.Service.Validator;

namespace Programming.Model
{
    /// <summary>
    /// Представляет класс Контакта, хранит контактные данные.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит фамилию контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает имя контакта. Должен состоять из букв или цифр.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = AssertStringContainsOnlyLetters(value, nameof(Name));
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должен состоять из букв или цифр.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = AssertStringContainsOnlyLetters(value, nameof(Surname));
        }

        /// <summary>
        /// Возвращает или задает номер контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает или задает дату создания контакта.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            CreateDate = DateTime.Now;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
        }
    }
}