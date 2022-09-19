using System;
using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об учебных дисциплинах.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Ноиер аудитории.
        /// </summary>
        private int _audienceNumber;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Discipline()
        {
        }

        /// <summary>
        /// Создаст экземпляр <see cref="Discipline"/>.
        /// </summary>
        /// <param name="titleName">Название.</param>
        /// <param name="audienceNumber">Номер аудитории.</param>
        /// <param name="teacherName">Имя преподователя.</param>
        public Discipline(string titleName, int audienceNumber, string teacherName)
        {
            AudienceNumber = audienceNumber;
            TitleName = titleName;
            TeacherName = teacherName;
        }

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        public string TitleName { get; set; }

        /// <summary>
        /// Возвращает и задает имя преподавателя.
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// Возвращает и задает номер аудитории.
        /// </summary>
        public int AudienceNumber
        {
            get => _audienceNumber;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(AudienceNumber));
                _audienceNumber = value;
            }
        }
    }
}