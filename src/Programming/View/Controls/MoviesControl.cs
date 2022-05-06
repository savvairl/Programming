using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    public partial class MoviesControl : UserControl
    {
        const int ElementsCount = 5;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random;

        public MoviesControl()
        {
            InitializeComponent();
            
            _random = new Random();
            _movies = CreateMovies();
            MovieListBox.SelectedIndex = 0;
        }

        private Movie[] CreateMovies()
        {
            Movie[] movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(10);
                _currentMovie.ReleaseYear = _random.Next(1900, 2022);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Film {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.Duration = _random.Next(1, 2000);
                movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Film {i + 1}");
            }
            return movies;
        }

        private int FindMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > maxValue)
                {
                    maxValue = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MovieListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            NameTextBox.Text = _currentMovie.Name;
            GenreTextBox.Text = _currentMovie.Genre;
            ReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            DurationTextBox.Text = _currentMovie.Duration.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingTextBox.Text;
                int rating = int.Parse(currentRating);
                _currentMovie.Rating = rating;
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RatingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string durationAsString = DurationTextBox.Text;
                int duration = int.Parse(durationAsString);
                _currentMovie.Duration = duration;
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            DurationTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = ReleaseTextBox.Text;
                int releaseYear = int.Parse(currentReleaseYear);
                _currentMovie.ReleaseYear = releaseYear;
            }
            catch
            {
                ReleaseTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            ReleaseTextBox.BackColor = AppColors.CorrectColor;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genre = GenreTextBox.Text;
            _currentMovie.Genre = genre;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            _currentMovie.Name = name;
        }
    }
}
