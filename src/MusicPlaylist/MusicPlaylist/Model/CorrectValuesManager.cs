using System.Windows.Forms;

namespace MusicPlaylist.Model
{
    /// <summary>
    /// Реализует статистическую обработку данных текстовых полей.
    /// </summary>
    public static class CorrectValuesManager
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
    }
}
