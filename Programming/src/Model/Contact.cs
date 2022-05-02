using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Programming.Model
{
    public class Contact
    {
        private string _name;

        private string _surname;

        public string Name
        {
            get => _name;
            set => _name = AssertStringContainsOnlyLetters(value, nameof(Name));
        }

        public string Surname
        {
            get => _surname;
            set => _surname = AssertStringContainsOnlyLetters(value, nameof(Surname));
        }

        public string PhoneNumber { get; set; }

        public DateTime CreateDate { get; set; }

        public Contact(string name, string phoneNumber, DateTime createDate)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            CreateDate = createDate;
        }

        public Contact()
        {
        }

        private string AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            return Regex.IsMatch(value, "[a-zA-Z0-9]")
                ? value
                : throw new ArgumentException($@"Некорректное значение в свойстве {nameof(propertyName)}!",
                    propertyName);
        }
    }
}