using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Services
{
    /// <summary>
    /// Хранит логику для преобразования значений.
    /// </summary>
    public class VisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение
        /// в соотвествующее значение из перечисления <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Значение из перечисления <see cref="Visibility"/>.</returns>
        public object Convert(object value, 
                              Type targetType, 
                              object parameter, 
                              CultureInfo culture)
        {
            var visibilityValue = Visibility.Hidden;

            switch (value)
            {
                case true:
                    {
                        visibilityValue = Visibility.Visible;
                        break;
                    }
                case false:
                    {
                        visibilityValue = Visibility.Hidden;
                        break;
                    }
            }

            return visibilityValue;
        }

        /// <summary>
        /// Конвертирует значение из перечисления <see cref="Visibility"/>
        /// в соотвествующее булевое значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Булевое значение.</returns>
        public object ConvertBack(object value, 
                                  Type targetType, 
                                  object parameter, 
                                  CultureInfo culture)
        {
            var visibilityValue = false;

            switch ((Visibility)value)
            {
                case Visibility.Visible:
                    {
                        visibilityValue = true;
                        break;
                    }
                case Visibility.Hidden:
                    {
                        visibilityValue = false;
                        break;
                    }
                case Visibility.Collapsed:
                    {
                        visibilityValue = false;
                        break;
                    }
            }

            return visibilityValue;
        }
    }
}
