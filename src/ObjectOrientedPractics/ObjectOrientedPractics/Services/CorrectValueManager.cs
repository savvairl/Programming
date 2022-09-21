using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Реализует статистическую обработку данных текстовых полей.
    /// </summary>
    public static class CorrectValueManager
    {
        /// <summary>
        /// Проверяет корректность введенных данных трёх текстовых полей.
        /// </summary>
        /// <param name="textBox1">Первое текстовое поле.</param>
        /// <param name="textBox2">Второе текстовое поле.</param>
        /// <param name="textBox3">Третье текстовое поле.</param>
        /// <returns>Возвращает true, если фоновые цвета всех текстовых полей корректные.
        /// И false, если нет.</returns>
        public static bool IsCorrect(TextBox textBox1, TextBox textBox2, TextBox textBox3)
        {
            return (textBox1.BackColor == AppColors.CorrectColor) &&
                   (textBox2.BackColor == AppColors.CorrectColor) &&
                   (textBox3.BackColor == AppColors.CorrectColor);
        }

        /// <summary>
        /// Проверяет корректность введенных данных двух текстовых полей.
        /// </summary>
        /// <param name="textBox1">Первое текстовое поле.</param>
        /// <param name="textBox2">Второе текстовое поле.</param>
        /// <returns>Возвращает true, если фоновые цвета всех текстовых полей корректные.
        /// И false, если нет.</returns>
        public static bool IsCorrect(TextBox textBox1, TextBox textBox2)
        {
            return (textBox1.BackColor == AppColors.CorrectColor) &&
                   (textBox2.BackColor == AppColors.CorrectColor);
        }
    }
}