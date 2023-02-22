using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет реализацию приоритета заказов.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
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
        /// Выбранный заказ.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder;

        /// <summary>
        /// Случайный товар.
        /// </summary>
        private Random _randomItem;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            _randomItem = new Random();
            _selectedPriorityOrder = new PriorityOrder();
            _selectedPriorityOrder.Items = new List<Item>();
            _selectedPriorityOrder.Address = new Address();
            IDTextBox.Text = _selectedPriorityOrder.Id.ToString();
            CreatedTextBox.Text = _selectedPriorityOrder.DateOfCreate;
            foreach (var time in _deliveryTime)
            {
                DeliveryTimeComboBox.Items.Add(time);
            }

            DeliveryTimeComboBox.SelectedIndex = 0;

            var statusValues = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statusValues)
            {
                StatusComboBox.Items.Add(status);
            }

            StatusComboBox.SelectedIndex = 0;
            addressControl1.Address = _selectedPriorityOrder.Address;
        }

        /// <summary>
        /// Возвращает и задаёт товары.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Создать приоритетный заказ.
        /// </summary>
        private void CreatePriorityOrder()
        {
            _selectedPriorityOrder = new PriorityOrder();
            _selectedPriorityOrder.Items = new List<Item>();
            _selectedPriorityOrder.Address = new Address();
            addressControl1.Address = _selectedPriorityOrder.Address;
            IDTextBox.Text = _selectedPriorityOrder.Id.ToString();
            CreatedTextBox.Text = _selectedPriorityOrder.DateOfCreate;
            DeliveryTimeComboBox.SelectedIndex = 0;
            StatusComboBox.SelectedIndex = 0;
            OrderItemsListBox.Items.Clear();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item item = Items[_randomItem.Next(Items.Count)];
            _selectedPriorityOrder.Items.Add(item);
            OrderItemsListBox.Items.Add(item.Name);
            AmountDigitLabel.Text = _selectedPriorityOrder.Amount.ToString();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = OrderItemsListBox.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            _selectedPriorityOrder.Items.RemoveAt(index);
            OrderItemsListBox.Items.RemoveAt(index);
            AmountDigitLabel.Text = _selectedPriorityOrder.Amount.ToString();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            CreatePriorityOrder();
        }
    }
}
