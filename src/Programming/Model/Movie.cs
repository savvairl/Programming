namespace Programming.Model
{
    class Movie
    {
        private int _releaseYear;
        private int _rating;
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
        public int Duration { get; set; }
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (value >= 1900 && value <= 2022)
                {
                    _releaseYear = value;
                }
                else
                {
                    throw new System.ArgumentException("Год релиза должен быть в пределах от 1900 до 2022 г.");
                }
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
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new System.ArgumentException("Рейтинг должен быть от 0 до 10");
                }
            }
        }
    }
}
