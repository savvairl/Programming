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
    /// Предоставляет реализацию по представлению окна добавления покупателя.
    /// </summary>
    public partial class AddCustomerForm : Form
    {
        /// <summary>
        /// Покупатель.
        /// </summary>
        private Customer _customer;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddCustomerForm"/>
        /// </summary>
        public AddCustomerForm()
        {
            InitializeComponent();

            _customer = new Customer();
            FullNameTextBox.Text = "Full name";
            AddressTextBox.Text = "Address";
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string customerNameString = FullNameTextBox.Text;
                _customer.Fullname = customerNameString;
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string customerAddressString = AddressTextBox.Text;
                _customer.Address = customerAddressString;
            }
            catch
            {
                AddressTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            AddressTextBox.BackColor = AppColors.CorrectColor;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CorrectValueManager.IsCorrect(FullNameTextBox, AddressTextBox))
            {
                CustomerData.Customer = _customer;
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
