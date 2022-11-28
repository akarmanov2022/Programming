using System;
using static Programming.Service.Validator;

namespace Programming.Model
{
    /// <summary>
    /// Контактная информация.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Вернуть или задать имя. Должно содержать только буквы.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = AssertStringContainsOnlyLetters(value, nameof(Name));
        }

        /// <summary>
        /// Вернуть или задать фамилию. Должно содержать только буквы.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set => _surname = AssertStringContainsOnlyLetters(value, nameof(Surname));
        }

        /// <summary>
        /// Вернуть или задать номер телефона.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Вернуть или задать дату создания.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Конструктор.
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