using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению окна добавления товара.
    /// </summary>
    public partial class AddItemForm : Form
    {
        /// <summary>
        /// Товар.
        /// </summary>
        private Item _item;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddItemForm"/>
        /// </summary>
        public AddItemForm()
        {
            InitializeComponent();

            _item = new Item();
            CostTextBox.Text = "123";
            NameTextBox.Text = "Name";
            InfoTextBox.Text = "Description";
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string costString = CostTextBox.Text;
                int costValue = int.Parse(costString);
                _item.Cost = costValue;
            }
            catch
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            CostTextBox.BackColor = AppColors.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string itemNameString = NameTextBox.Text;
                _item.Name = itemNameString;
            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            NameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string itemInfoString = InfoTextBox.Text;
                _item.Info = itemInfoString;
            }
            catch
            {
                InfoTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            InfoTextBox.BackColor = AppColors.CorrectColor;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CorrectValueManager.IsCorrect(CostTextBox, NameTextBox, InfoTextBox))
            {
                ItemData.Item = _item;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введены неверные значения.", "Error");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
