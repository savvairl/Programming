using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _selectedCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTab"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    UpdateListBox(-1);
                }
            }
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateListBox(int selectedIndex)
        {
            CustomersListBox.Items.Clear();
            var orderedListItems = from customer in _customers
                                   orderby customer.Fullname
                                   select customer;

            _customers = orderedListItems.ToList();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add(FormatText(customer));
            }

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Ищет индекс элемента по уникальному идентификатору.
        /// </summary>
        /// <returns>Возвращает индекс найденного элемента.</returns>
        private int FindCustomerIndexById()
        {
            var orderedListItems = from customer in _customers
                                   orderby customer.Fullname
                                   select customer;

            _customers = orderedListItems.ToList();
            int currentCustomerId = _selectedCustomer.Id;
            int index = -1;

            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Id != currentCustomerId) continue;

                index = i;
                break;
            }

            return index;
        }

        /// <summary>
        /// Очищает поля вывода информации.
        /// </summary>
        private void ClearAllFields()
        {
            IDTextBox.Clear();
            FullNameTextBox.Clear();
            addressControl1.Clear();
        }

        /// <summary>
        /// Приводит текст к нужному формату.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <returns>Возвращает отформатированный текст.</returns>
        private string FormatText(Customer customer)
        {
            return $"{customer.Fullname}";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.CreateCustomer();
            _selectedCustomer = customer;
            _customers.Add(customer);
            UpdateListBox(0);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _customers.RemoveAt(index);
            UpdateListBox(-1);
            ClearAllFields();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _selectedCustomer = _customers[index];

            IDTextBox.Text = _selectedCustomer.Id.ToString();
            FullNameTextBox.Text = _selectedCustomer.Fullname;
            addressControl1.Address = _selectedCustomer.Address;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string name = FullNameTextBox.Text;
                _selectedCustomer.Fullname = name;
                int indexofCustomer = FindCustomerIndexById();
                UpdateListBox(indexofCustomer);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            FullNameTextBox.BackColor = AppColor.CorrectColor;
        }
    }
}
