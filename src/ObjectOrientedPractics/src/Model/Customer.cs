using System;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект "Покупатель".
    /// </summary>
    public class Customer
    {
        public const int MaxLengthFullname = 200;
        public const int MaxLengthAddress = 500;

        /// <summary>
        /// Хранит полное имя <see cref="Customer"/>.
        /// </summary>
        private string _fullname;

        /// <summary>
        ///  Хранит адрес <see cref="Customer"/>.
        /// </summary>
        private string _address;
        
        /// <summary>
        /// Возвращает значение иденитфикатора.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает или задает знаяение полного имени. Длина строки не должна превышать <see cref="MaxLengthFullname"/>/>
        /// </summary>
        public string Fullname
        {
            get => $"{LastName} {FirstName} {FatherName}";
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxLengthFullname, nameof(Fullname));
                var strings = value.Split(' ');
                LastName = strings[0] ?? "";
                FirstName = strings[1] ?? "";
                FatherName = strings[2] ?? "";
            }
        }

        public string LastName { get; set; }

        public  string FirstName { get; set; }

        public  string FatherName { get; set; }


        /// <summary>
        /// Возвращает или задает знаяение адреса. Длина строки не должна превышать <see cref="MaxLengthAddress"/>/>
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxLengthAddress, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создает эземпляр объекта <see cref="Customer"/> .
        /// </summary>
        /// <param name="fullname">Значение полного имени.</param>
        /// <param name="address">Значение адреса.</param>
        public Customer(string fullname, string address)
        {
            Id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }

        public Customer()
        {
            Id = IdGenerator.GetNextId();
        }
        
        public override string ToString()
        {
            return Fullname;
        }
    }
}