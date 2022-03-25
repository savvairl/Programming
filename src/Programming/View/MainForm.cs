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
        const int CountElements = 5;
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;
        private Random _randomValues;
        public MainForm()
        {
            InitializeComponent();
            _randomValues = new Random();
            _rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Color));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _randomValues.Next(101);
                _currentRectangle.Length = _randomValues.Next(101);
                _currentRectangle.Color = colors.GetValue(_randomValues.Next(0, colors.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            RectanglesListBox.SelectedIndex = 0;

            _movies = new Movie[CountElements];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < CountElements; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _randomValues.Next(11);
                _currentMovie.ReleaseYear = _randomValues.Next(1900, 2022);
                _currentMovie.Genre = genres.GetValue(_randomValues.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.Duration = _randomValues.Next(150);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonChooseCombobox.DataSource = Enum.GetValues(typeof(Season));
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
                string currentLength = LengthTextBox.Text;
                double lengthRectangleValue = double.Parse(currentLength);
                _currentRectangle.Length = lengthRectangleValue;
            }
            catch (ArgumentException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            LengthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidthRectangle = WidthTextBox.Text;
                double widthRectangleValue = double.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch (ArgumentException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            WidthTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private int FindMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
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
            string nameValue = NameTextBox.Text;
            _currentMovie.Name = nameValue;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreValue = GenreTextBox.Text;
            _currentMovie.Genre = genreValue;
        }

        private void ReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = ReleaseTextBox.Text;
                int ReleaseYearValue = int.Parse(currentReleaseYear);
                _currentMovie.ReleaseYear = ReleaseYearValue;
            }
            catch (ArgumentException)
            {
                ReleaseTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            ReleaseTextBox.BackColor = System.Drawing.Color.White;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDuration = DurationTextBox.Text;
                int DurationValue = int.Parse(currentDuration);
                _currentMovie.Duration = DurationValue;
            }
            catch (ArgumentException)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            DurationTextBox.BackColor = System.Drawing.Color.White;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingTextBox.Text;
                int RatingValue = int.Parse(currentRating);
                _currentMovie.Rating = RatingValue;
            }
            catch (ArgumentException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
            RatingTextBox.BackColor = System.Drawing.Color.White;
        }

        private int FindMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (movies[i].Rating > maxValue)
                {
                    maxValue = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }
    }
}
