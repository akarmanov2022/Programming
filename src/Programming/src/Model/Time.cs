using System;
using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Представляет модель - Время.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Значение часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Значение минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Значение секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Time()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает или задает значение часов.
        /// Значение должно быть от 0 до 23.
        /// </summary>
        public int Hours
        {
            get => _hours;
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение минут.
        /// Значение должно быть от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 59, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает или задает значение секунд.
        /// Значение должно быть от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertOnPositiveValue(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }
    }
}