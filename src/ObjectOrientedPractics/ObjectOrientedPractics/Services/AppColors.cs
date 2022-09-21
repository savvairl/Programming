using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
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
    }
}