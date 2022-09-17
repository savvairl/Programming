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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AddItemForm : Form
    {
        private Item _item;

        public AddItemForm()
        {
            InitializeComponent();

            _item = new Item();
            CostTextBox.Text = "123";
            NameTextBox.Text = "Name";
            DescriptionTextBox.Text = "Description";
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

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string itemDescriptionString = DescriptionTextBox.Text;
                _item.Info = itemDescriptionString;
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            DescriptionTextBox.BackColor = AppColors.CorrectColor;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CorrectValueManager.IsCorrect(CostTextBox, NameTextBox, DescriptionTextBox))
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
