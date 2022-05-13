using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Год релиза фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private int _rating;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="releaseYear">Год релиза фильма. Должно быть в диапазоне от 1900 до 2022.</param>
        /// <param name="duration">Продолжительность фильма в минутах. Должно быть положительным числом.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10.</param>
        /// <param name="name">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        public Movie(string name, string genre, int duration, int releaseYear, int rating)
        {
            Name = name;
            Genre = genre;
            Duration = duration;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах. Должна быть положительным числом.
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

        /// <summary>
        /// Возвращает и задаёт год релиза фильма. Должен быть в диапазоне от 1900 до 2022.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                DateTime currentYear = DateTime.Now;
                int year = currentYear.Year;
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, year);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Должен быть в диапазоне от 0 до 10.
        /// </summary>
        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 0, 10);
                _rating = value;
            }
        }
    }
}
