using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет объект - адрес.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна/регион. Не более 50 символов.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город (населенный пункт), строка, не более 50 символов.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица, строка, не более 100 символов.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома, строка, не более 10 символов.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры/помещения, не более 10 символов.
        /// </summary>
        private string _apartment;

        public int Index
        {
            get => _index;
            set
            {
                ValueValidator.AssertOnPositiveValue(value, 0, 999_999, nameof(Index));
                _index = value;
            }
        }

        public string Country
        {
            get => _country ?? "";
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        public string City
        {
            get => _city ?? "";
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        public string Street
        {
            get => _street ?? "";
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        public string Building
        {
            get => _building ?? "";
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        public string Apartment
        {
            get => _apartment ?? "";
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        public Address()
        {
        }

        public override string ToString()
        {
            return string.Join(", ", Index.ToString(), Country, City, Street, Building, Apartment);
        }
    }
}