using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectangleCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectangleCollisionControl"/>.
        /// </summary>
        public RectangleCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        /// <summary>
        /// Преобразует и форматирует данные прямоугольника в удобный формат.
        /// Вид: Id, X, Y, W, H.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Height})";
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их в определённый цвет.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColors.IsNotCollision;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.IsCollision;
                        CanvasPanel.Controls[j].BackColor = AppColors.IsCollision;
                    }
                }
            }
        }

        /// <summary>
        /// Очищает информацию текстовых полей и списка.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
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

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int id = RectanglesListBox.FindString(rectangle.Id.ToString());

            if (id == -1) return;

            RectanglesListBox.Items[id] = FormattedText(_currentRectangle);
        }

        private void SelectedRectangleXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentRectangleX = SelectedRectangleXTextBox.Text;
                int rectangleXValue = int.Parse(currentRectangleX);
                _currentRectangle.Center.X = rectangleXValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location = 
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentRectangleY = SelectedRectangleYTextBox.Text;
                int rectangleYValue = int.Parse(currentRectangleY);
                _currentRectangle.Center.Y = rectangleYValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location = 
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentRectangleWidth = SelectedRectangleWidthTextBox.Text;
                int widthRectangleValue = int.Parse(currentRectangleWidth);
                _currentRectangle.Width = widthRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentRectangleHeight = SelectedRectangleHeightTextBox.Text;
                int heightRectangleValue = int.Parse(currentRectangleHeight);
                _currentRectangle.Height = heightRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
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
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle != -1)
            {
                _rectanglePanels.RemoveAt(indexSelectedRectangle);
                _rectangles.RemoveAt(indexSelectedRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox.Items.Add(FormattedText(_rectangles[i]));
                    RectanglesListBox.SelectedIndex = 0;
                }

                CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
                FindCollisions();
            }
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(_currentRectangle);
            RectanglesListBox.Items.Add(FormattedText(_currentRectangle));
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.IsNotCollision;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(RectanglesListBox.SelectedItem == null))
            {
                int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[selectedIndexRectangle];
                SelectedRectangleIdTextBox.Text = _currentRectangle.Id.ToString();
                SelectedRectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
                SelectedRectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
                SelectedRectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
                SelectedRectangleHeightTextBox.Text = _currentRectangle.Height.ToString();
            }
        }
    }
}
