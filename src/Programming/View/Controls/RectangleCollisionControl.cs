using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectangleCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels;

        private int _canvasWidth;

        private int _canvasHeight;

        public RectangleCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();

            _canvasWidth = CanvasPanel.Width;
            _canvasHeight = CanvasPanel.Height;
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

        private void ClearRectangleInfo()
        {
            RectanglesListBox2.Items.Clear();
            SelectedRectangleIdTextBox.Clear();
            SelectedRectangleXTextBox.Clear();
            SelectedRectangleYTextBox.Clear();
            SelectedRectangleWidthTextBox.Clear();
            SelectedRectangleHeightTextBox.Clear();
            SelectedRectangleXTextBox.BackColor = AppColors.CorrectColor;
            SelectedRectangleYTextBox.BackColor = AppColors.CorrectColor;
            SelectedRectangleWidthTextBox.BackColor = AppColors.CorrectColor;
            SelectedRectangleHeightTextBox.BackColor = AppColors.CorrectColor;
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int id = RectanglesListBox2.FindString(rectangle.Id.ToString());

            if (id == -1) return;

            RectanglesListBox2.Items[id] = $"{rectangle.Id}: " + $"(X: {rectangle.Center.X};" + $" Y: {rectangle.Center.Y};" + $" W: {rectangle.Width};" + $" H: {rectangle.Height})";
        }

        private void CanvasPanel_Resize(object sender, EventArgs e)
        {
            _canvasHeight = CanvasPanel.Height;
            _canvasWidth = CanvasPanel.Width;
        }

        private void SelectedRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex == -1) return;

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
                SelectedRectangleXTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleXTextBox.BackColor = AppColors.CorrectColor;
        }

        private void SelectedRectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex == -1) return;

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
                SelectedRectangleYTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleYTextBox.BackColor = AppColors.CorrectColor;
        }

        private void SelectedRectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex == -1) return;

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
                SelectedRectangleWidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleWidthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void SelectedRectangleHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex == -1) return;

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
                SelectedRectangleHeightTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            SelectedRectangleHeightTextBox.BackColor = AppColors.CorrectColor;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_remove_24x24_uncolor.png");
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_remove_24x24.png");
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_add_24x24_uncolor.png");
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Image.FromFile(@"C:\Users\sav\Source\Repos\savvairl\Programming\src\Programming\Resources\rectangle_add_24x24.png");
        }

        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(RectanglesListBox2.SelectedItem == null))
            {
                int selectedIndexRectangle = RectanglesListBox2.SelectedIndex;
                _currentRectangle = _rectangles[selectedIndexRectangle];
                SelectedRectangleIdTextBox.Text = _currentRectangle.Id.ToString();
                SelectedRectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
                SelectedRectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
                SelectedRectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                SelectedRectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            }
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox2.SelectedIndex;

            if (indexSelectedRectangle != -1)
            {
                _rectanglePanels.RemoveAt(indexSelectedRectangle);
                _rectangles.RemoveAt(indexSelectedRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox2.Items.Add($"{_rectangles[i].Id}: " + $"(X: {_rectangles[i].Center.X};" + $" Y: {_rectangles[i].Center.Y};" + $" W: {_rectangles[i].Width};" + $" H: {_rectangles[i].Height})");
                    RectanglesListBox2.SelectedIndex = 0;
                }

                CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
                FindCollisions();
            }
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(_canvasWidth, _canvasHeight);
            _rectangles.Add(_currentRectangle);
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

        private void RectangleCollisionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
