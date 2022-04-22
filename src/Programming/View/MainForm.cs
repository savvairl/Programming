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
using Programming.Model.Geometry;
using Color = Programming.Model.Color;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly System.Drawing.Color _errorcolor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color _correctcolor = System.Drawing.Color.White;

        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private List<Panel> _rectanglePanels;

        private Movie _currentMovie;

        private Random _random;

        public MainForm()
        {
            InitializeComponent();
            InitMovies();
            _random = new Random();
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonChooseCombobox.DataSource = Enum.GetValues(typeof(Season));
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
                _currentMovie.Duration = _random.Next(30, 200);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        CanvasPanel.Controls[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private int FindMaxWidth(List<Rectangle> rectangles)
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
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleLength = HeightTextBox.Text;
                int rectangleLength = int.Parse(currentRectangleLength);
                _currentRectangle.Height = rectangleLength;
            }
            catch
            {
                HeightTextBox.BackColor = _errorcolor;
                return;
            }
            HeightTextBox.BackColor = _correctcolor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleWidth = WidthTextBox.Text;
                int rectangleWidth = int.Parse(currentRectangleWidth);
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var colors = Enum.GetValues(typeof(Color));
            _currentRectangle = new Rectangle();
            _currentRectangle.Width = _random.Next(50, 105);
            _currentRectangle.Height = _random.Next(50, 105);
            _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            _currentRectangle.Center = new Point2D(_random.Next(1, 400), _random.Next(1, 200));
            _rectangles.Add(_currentRectangle);
            RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            RectanglesListBox2.Items.Add($"{_currentRectangle.Id}: " + $"(X: {_currentRectangle.Center.X};" + $" Y: {_currentRectangle.Center.Y};" + $" W: {_currentRectangle.Width};" + $" H: {_currentRectangle.Height})");
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectanglesListBox2.SelectedIndex;
            if (selectedIndexRectangle != -1)
            {
                _rectanglePanels.RemoveAt(selectedIndexRectangle);
                _rectangles.RemoveAt(selectedIndexRectangle);
                RectanglesListBox2.Items.Clear();
                SelectedRectangleIdTextBox.Clear();
                SelectedRectangleXTextBox.Clear();
                SelectedRectangleYTextBox.Clear();
                SelectedRectangleWidthTextBox.Clear();
                SelectedRectangleHeightTextBox.Clear();
                SelectedRectangleXTextBox.BackColor = _correctcolor;
                SelectedRectangleYTextBox.BackColor = _correctcolor;
                SelectedRectangleWidthTextBox.BackColor = _correctcolor;
                SelectedRectangleHeightTextBox.BackColor = _correctcolor;
                RectanglesListBox.Items.Clear();
                XTextBox.Clear();
                YTextBox.Clear();
                WidthTextBox.Clear();
                HeightTextBox.Clear();
                IdTextBox.Clear();
                ColorTextBox.Clear();
                WidthTextBox.BackColor = _correctcolor;
                HeightTextBox.BackColor = _correctcolor;

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox2.Items.Add($"{_rectangles[i].Id}: " + $"(X: {_rectangles[i].Center.X};" + $" Y: {_rectangles[i].Center.Y};" + $" W: {_rectangles[i].Width};" + $" H: {_rectangles[i].Height})");
                    RectanglesListBox2.SelectedIndex = 0;
                    RectanglesListBox.Items.Add($"Rectangle {_rectangles[i].Id}");
                    RectanglesListBox.SelectedIndex = 0;
                }

                CanvasPanel.Controls.RemoveAt(selectedIndexRectangle);
                FindCollisions();
            }
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_add_24x24.png");
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_add_24x24_uncolor.png");
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_remove_24x24.png");
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_remove_24x24_uncolor.png");
        }

        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectanglesListBox2.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            SelectedRectangleIdTextBox.Text = _currentRectangle.Id.ToString();
            SelectedRectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            SelectedRectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            SelectedRectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            SelectedRectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
        }

        private void SelectedRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleX = SelectedRectangleXTextBox.Text;
                int rectangleXValue = int.Parse(currentRectangleX);
                _currentRectangle.Center.X = rectangleXValue;
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
            }
            catch
            {
                SelectedRectangleXTextBox.BackColor = _errorcolor;
                return;
            }
            SelectedRectangleXTextBox.BackColor = _correctcolor;
        }

        private void SelectedRectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleY = SelectedRectangleYTextBox.Text;
                int rectangleYValue = int.Parse(currentRectangleY);
                _currentRectangle.Center.Y = rectangleYValue;
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
            }
            catch
            {
                SelectedRectangleYTextBox.BackColor = _errorcolor;
                return;
            }
            SelectedRectangleYTextBox.BackColor = _correctcolor;
        }

        private void SelectedRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleWidth = SelectedRectangleWidthTextBox.Text;
                int widthRectangleValue = int.Parse(currentRectangleWidth);
                _currentRectangle.Width = widthRectangleValue;
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
            }
            catch
            {
                SelectedRectangleWidthTextBox.BackColor = _errorcolor;
                return;
            }
            SelectedRectangleWidthTextBox.BackColor = _correctcolor;
        }

        private void SelectedRectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRectangleHeight = SelectedRectangleHeightTextBox.Text;
                int heightRectangleValue = int.Parse(currentRectangleHeight);
                _currentRectangle.Height = heightRectangleValue;
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
            }
            catch
            {
                SelectedRectangleHeightTextBox.BackColor = _errorcolor;
                return;
            }
            SelectedRectangleHeightTextBox.BackColor = _correctcolor;
        }
    }
}
