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
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Путь до директории AppData.
        /// </summary>
        private string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _selectedCustomer;

        /// <summary>
        /// Окно добавления покупателя.
        /// </summary>
        private AddCustomerForm _addCustomerForm;

        /// <summary>
        /// Окно редактирования данных покупателя.
        /// </summary>
        private EditCustomerForm _editCustomerForm;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            _customers = CustomerSerializer.Deserialize(AppDataPath);
            UpdateListBox(-1);
        }

        /// <summary>
        /// Очищает все поля.
        /// </summary>
        private void ClearAllFields()
        {
            IDTextBox.Clear();
            AddressTextBox.Clear();
            FullNameTextBox.Clear();
        }

        /// <summary>
        /// Ищет индекс элемента по уникальному идентификатору.
        /// </summary>
        /// <returns>Возвращает индекс найденного элемента.</returns>
        private int FindItemIndexById()
        {
            int index = _customers.IndexOf(_selectedCustomer);
            return index;
        }

        /// <summary>
        /// Обновляет данные в списке ListBox.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateListBox(int selectedIndex)
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.Fullname} - {customer.Address}");
            }

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            _addCustomerForm = new AddCustomerForm();

            if (_addCustomerForm.ShowDialog() != DialogResult.OK) return;

            _customers.Add(CustomerData.Customer);
            CustomerSerializer.Serialize(AppDataPath, _customers);
            UpdateListBox(0);
        }

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _customers.RemoveAt(index);
            UpdateListBox(-1);
            ClearAllFields();
            CustomerSerializer.Serialize(AppDataPath, _customers);
        }

        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            CustomerData.Customer = _selectedCustomer;

            _editCustomerForm = new EditCustomerForm();

            if (_editCustomerForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _selectedCustomer = CustomerData.Customer;

            int index = FindItemIndexById();
            UpdateListBox(index);
            CustomerSerializer.Serialize(AppDataPath, _customers);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _selectedCustomer = _customers[index];
            FullNameTextBox.Text = _selectedCustomer.Fullname;
            AddressTextBox.Text = _selectedCustomer.Address;
            IDTextBox.Text = _selectedCustomer.Id.ToString();
        }
    }
}
