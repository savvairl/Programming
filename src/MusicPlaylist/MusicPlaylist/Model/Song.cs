using System;

namespace MusicPlaylist.Model
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Количество песен.
        /// </summary>
        private static int _allSongsCount;

        /// <summary>
        /// Название песни.
        /// </summary>
        private string _songName;

        /// <summary>
        /// Имя исполнителя.
        /// </summary>
        private string _artist;

        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {
            _allSongsCount++;
            _id = _allSongsCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор песни.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр песни.
        /// </summary>
        public Genre Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должно быть не более 7200 секунд.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Duration), 1, 7200, value);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя исполнителя. Должно быть не более 50 символов.
        /// </summary>
        public string Artist
        {
            get
            {
                return _artist;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Artist), 1, 50, value);
                _artist = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название песни. Должно быть не более 55 символов.
        /// </summary>
        public string SongName
        {
            get
            {
                return _songName;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(SongName), 1, 55, value);
                _songName = value;
            }
        }
    }
}
