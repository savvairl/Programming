using System;
using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static System.Drawing.Color IsCollision = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет непересекающихся фигур.
        /// </summary>
        public static System.Drawing.Color IsNotCollision = System.Drawing.Color.FromArgb(127, 127, 255, 127);
    }
}
