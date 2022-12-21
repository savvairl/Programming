using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по отображению заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Коллекция заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder;

        /// <summary>
        /// Выбранный приоритетный заказ.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Время доставки.
        /// </summary>
        private string[] _deliveryTime =
        {
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            _orders = new List<Order>();

            var orderStatusValues = Enum.GetValues(typeof(OrderStatus));

            foreach (var value in orderStatusValues)
            {
                StatusComboBox.Items.Add(value);
            }
            foreach (var time in _deliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }

            PriorityPanel.Visible = false;
            StatusComboBox.Enabled = false;
        }

        /// <summary>
        /// Обновляет информацию о заказах.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
        }

        /// <summary>
        /// Обновляет заказы.
        /// </summary>
        private void UpdateOrders()
        {
            foreach (var customer in _customers)
            {
                Address address = customer.Address;
                string fullAddress = $"{address.Index}, {address.Country}, {address.City}," +
                                     $" {address.Street}, {address.Building}, {address.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(order.Id.ToString(), order.Total.ToString(), order.DateOfCreate,
                        order.Status, customer.Fullname, fullAddress, order.Amount.ToString());
                }
            }
        }

        /// <summary>
        /// Заполняет поля.
        /// </summary>
        private void FillTextBoxes()
        {
            StatusComboBox.Enabled = true;
            IDTextBox.Text = _selectedOrder.Id.ToString();
            CreatedTextBox.Text = _selectedOrder.DateOfCreate;
            StatusComboBox.SelectedIndex = (int)_selectedOrder.Status;
            addressControl1.Address = _selectedOrder.Address;
            AmountDigitLabel.Text = _selectedOrder.Amount.ToString();
            TotalAmountDigitLabel.Text = _selectedOrder.Total.ToString();

            OrderItemsListBox.Items.Clear();
            foreach (var item in _selectedOrder.Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
            if(_selectedOrder is PriorityOrder priority)
            {
                DeliveryTimeComboBox.SelectedIndex = Array.IndexOf(_deliveryTime, _selectedPriorityOrder.DeliveryTime);
            }
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;

                if (_customers != null) UpdateOrders();
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            if (index == -1)
            {
                return;
            }

            _selectedOrder = _orders[index];

            if (_selectedOrder is PriorityOrder priority)
            {
                _selectedPriorityOrder = (PriorityOrder)_orders[index];
                PriorityPanel.Visible = true;
            }
            else
            {
                PriorityPanel.Visible = false;
                _selectedPriorityOrder = null;
            }
            FillTextBoxes();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrdersDataGridView.CurrentCell.RowIndex;

            _selectedOrder.Status = (OrderStatus)StatusComboBox.SelectedIndex;
            OrdersDataGridView.Rows[index].Cells[2].Value = (OrderStatus)StatusComboBox.SelectedIndex;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}
