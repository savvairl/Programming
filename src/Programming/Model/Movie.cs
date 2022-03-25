﻿using System;


namespace Programming.Model
{
    class Movie
    {
        private int _releaseYear;

        private int _rating;

        private int _duration;

        public Movie()
        {

        }

        public Movie(string name, string genre, int duration, int releaseYear, int rating)
        {
            Name = name;
            Genre = genre;
            Duration = duration;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("Значение должно быть больше нуля");
                }

                _duration = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                DateTime myDateTime = DateTime.Now;
                int year = myDateTime.Year;
                if (value < 1900 || value > year)
                {
                    throw new System.ArgumentException($"Год релиза должен быть в пределах от 1900 до {year} г.");
                }

                _releaseYear = value;
            }
        }

        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new System.ArgumentException("Рейтинг должен быть от 0 до 10");
                }

                _rating = value;
            }
        }
    }
}
