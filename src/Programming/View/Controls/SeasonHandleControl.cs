using System;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по изменению цвета фона окна.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();

            Array seasons = Enum.GetValues(typeof(Season));
            foreach (Season value in seasons)
            {
                SeasonChooseCombobox.Items.Add(value);
            }
            SeasonChooseCombobox.SelectedIndex = 0;
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
    }
}
