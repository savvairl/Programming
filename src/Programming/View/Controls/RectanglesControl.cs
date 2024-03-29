﻿using System;
using Programming.Model;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Geometry;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников, генерируемых программой.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Количество элементов.
        /// </summary>
        const int ElementsCount = 5;

        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Инициализирует коллекцию прямоугольников.
        /// </summary>
        /// <returns>Возвращает коллекцию прямоугольников.</returns>
        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[ElementsCount];
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        /// <summary>
        /// Находит прямоугольник, чья ширина больше остальных.
        /// </summary>
        /// <param name="rectangles">Прямоугольник.</param>
        /// <returns>Индекс элемента массива, ширина прямоугольника которого больше остальных.</returns>
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            int selectedIndexRectangles = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangles];
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentLengthLength = HeightTextBox.Text;
                int lengthRectangleValue = int.Parse(currentLengthLength);
                _currentRectangle.Height = lengthRectangleValue;
            }
            catch
            {
                HeightTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            HeightTextBox.BackColor = AppColors.CorrectColor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = WidthTextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private void RectanglesFindButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.Items.Count == 0) return;
            int findMaxWidthIndex = FindMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }
    }
}
