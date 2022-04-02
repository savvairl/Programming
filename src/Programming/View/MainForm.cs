using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Color = Programming.Model.Color;
using Rectangle = Programming.Model.Rectangle;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly System.Drawing.Color _errorcolor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color _correctcolor = System.Drawing.Color.White;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random;

        public MainForm()
        {
            InitializeComponent();
            InitRectangles();
            InitMovies();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonChooseCombobox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void InitRectangles()
        {
            _random = new Random();
            _rectangles = new Rectangle[ElementsCount];
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _random.Next(101);
                _currentRectangle.Length = _random.Next(101);
                _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            RectanglesListBox.SelectedIndex = 0;
        }

        private void InitMovies()
        {
            _random = new Random();
            _movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(11);
                _currentMovie.ReleaseYear = _random.Next(1900, 2022);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.Duration = _random.Next(200);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private int FindMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
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

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Color:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Color));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufacture:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacture));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            ValuesTextBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(ParsingValueTextbox.Text, out weekday))
            {
                WeekParseLabel.Text = $"Это день недели ({weekday} = {(int)weekday}).";
            }
            else
            {
                WeekParseLabel.Text = "Нет такого дня недели.";
            }
        }

        private void SeasonChooseButton_Click(object sender, EventArgs e)
        {
            switch ((Season)SeasonChooseCombobox.SelectedItem)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    BackColor = System.Drawing.Color.Green;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    BackColor = System.Drawing.Color.Orange;
                    break;
                default:
                    MessageBox.Show("Сезон не выбран", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void RectanglesFindButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangles = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangles];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleLength = LengthTextBox.Text;
                double rectangleLength = double.Parse(currentRectangleLength);
                _currentRectangle.Length = rectangleLength;
            }
            catch
            {
                LengthTextBox.BackColor = _errorcolor;
                return;
            }
            LengthTextBox.BackColor = _correctcolor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleWidth = WidthTextBox.Text;
                double rectangleWidth = double.Parse(currentRectangleWidth);
                _currentRectangle.Width = rectangleWidth;
            }
            catch
            {
                WidthTextBox.BackColor = _errorcolor;
                return;
            }
            WidthTextBox.BackColor = _correctcolor;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangle = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangle;
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

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            _currentMovie.Name = name;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genre = GenreTextBox.Text;
            _currentMovie.Genre = genre;
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
                ReleaseTextBox.BackColor = _errorcolor;
                return;
            }
            ReleaseTextBox.BackColor = _correctcolor;
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
                DurationTextBox.BackColor = _errorcolor;
                return;
            }
            DurationTextBox.BackColor = _correctcolor;
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
                RatingTextBox.BackColor = _errorcolor;
                return;
            }
            RatingTextBox.BackColor = _correctcolor;
        }
    }
}
