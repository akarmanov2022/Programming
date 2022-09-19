using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об авиарейсах.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Время полета.
        /// </summary>
        private int _time;

        /// <summary>
        /// Возвращает или задает название пункта отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Возвращает или задает название пункта назначения.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Flight()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="time">Время полета.</param>
        /// <param name="departure">пункт отправления.</param>
        /// <param name="destination">пункт назначения.</param>
        public Flight(int time, string departure, string destination)
        {
            Time = time;
            Departure = departure;
            Destination = destination;
        }

        /// <summary>
        /// Возвращает или задает время полета.
        /// </summary>
        public int Time
        {
            get => _time;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Time));
                _time = value;
            }
        }
    }
}