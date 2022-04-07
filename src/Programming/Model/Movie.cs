using System;

namespace Programming.Model
{
    public class Movie
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
                Validator.AssertOnPositiveValue(nameof(Duration), value);
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
                DateTime currentYear = DateTime.Now;
                int year = currentYear.Year;
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, year);
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
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 0, 10);
                _rating = value;
            }
        }
    }
}
