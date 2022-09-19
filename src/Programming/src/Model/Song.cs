using Programming.Service;

namespace Programming.Model
{
    /// <summary>
    /// Представляет модель звукозаписи.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность звукозаписи.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Название звукозаписи.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Имя артиста.
        /// </summary>
        public string ArtistName { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="duration">Продолжительность звукозаписи.</param>
        /// <param name="name">Название звукозаписи.</param>
        /// <param name="artistName">Имя артиста.</param>
        public Song(int duration, string name, string artistName)
        {
            Duration = duration;
            Name = name;
            ArtistName = artistName;
        }

        /// <summary>
        /// Возвращает или задает значение <see cref="_duration"/>. Должно быть положительным.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }
    }
}