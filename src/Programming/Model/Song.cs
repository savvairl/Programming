using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="artist">Имя исполнителя.</param>
        /// <param name="name">Название песни.</param>
        /// <param name="duration">Продолжительность песни в секундах. Должна быть положительным числом.</param>
        public Song(string artist, string name, int duration)
        {
            Artist = artist;
            Name = name;
            Duration = duration;
        }

        /// <summary>
        /// Возвращает и задаёт имя исполнителя.
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должна быть положительным числом.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                _duration = value;
            }
        }
    }
}
