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
        /// Возвращает значение идентификатора.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Возвращает или задает значение полного имени. Длина строки не должна превышать <see cref="MaxLengthFullname"/>/>
        /// </summary>
        public string Fullname
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_fullname)) _fullname = $"{LastName} {FirstName} {FatherName}";
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, MaxLengthFullname, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение фамилии.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Возвращает или задает значение имени.
        /// </summary>
        public  string FirstName { get; set; }

        /// <summary>
        /// Возвращает или задает значение отчества.
        /// </summary>
        public  string FatherName { get; set; }


        /// <summary>
        /// Возвращает или задает значение адреса. Длина строки не должна превышать <see cref="MaxLengthAddress"/>/>
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
        /// Конструктор по умолчанию. 
        /// </summary>
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