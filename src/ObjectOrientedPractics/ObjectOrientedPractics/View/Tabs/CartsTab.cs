using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению корзины товаров покупателя.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Создает экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;

                if (_items != null)
                {
                    UpdateItemsListBox(-1);
                }
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

                if (_customers != null)
                {
                    foreach (var customer in _customers)
                    {
                        CustomerComboBox.Items.Add(customer.Fullname);
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает и задает выбранного покупателя.
        /// </summary>
        private Customer SelectedCustomer { get; set; }

        /// <summary>
        /// Обновляет данные в списках.
        /// </summary>
        public void RefreshData()
        {
            UpdateItemsListBox(-1);

            CustomerComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomerComboBox.Items.Add(customer.Fullname);
            }

            if (CustomerComboBox.Items.Count > 0)
            {
                CustomerComboBox.SelectedIndex = 0;
            }
            else
            {
                CustomerComboBox.SelectedIndex = -1;
            }

            UpdateDiscountAmount();
        }

        /// <summary>
        /// Сортирует и обновляет данные в списке с товарами.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateItemsListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            var orderedListItems = from item in _items
                                   orderby item.Name
                                   select item;

            _items = orderedListItems.ToList();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add(FormatText(item));
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Сортирует и обновляет данные в списке с корзиной.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateCartListBox(int selectedIndex)
        {
            CartListBox.Items.Clear();

            var orderedListItems = from item in SelectedCustomer.Cart.Items
                                   orderby item.Name
                                   select item;

            SelectedCustomer.Cart.Items = orderedListItems.ToList();

            foreach (Item item in SelectedCustomer.Cart.Items)
            {
                CartListBox.Items.Add(FormatText(item));
            }

            CartListBox.SelectedIndex = selectedIndex;
        }

        private void UpdateDiscountAmount()
        {
            double discountAmount = 0;

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += SelectedCustomer.Discounts[i].Calculate(SelectedCustomer.Cart.Items);
                }
            }

            DiscountAmountLabel.Text = discountAmount.ToString();
            if (SelectedCustomer.Cart.Amount == 0)
            {
                TotalAmountLabel.Text = SelectedCustomer.Cart.Amount.ToString();
                return;
            }

            TotalAmountLabel.Text = (SelectedCustomer.Cart.Amount - discountAmount).ToString();
        }

        private void UpdateDiscountCheckedListBox()
        {
            DiscountCheckedListBox.Items.Clear();

            foreach (var discount in SelectedCustomer.Discounts)
            {
                DiscountCheckedListBox.Items.Add(discount.Info, true);
            }
        }

        /// <summary>
        /// Форматирует текст.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormatText(Item item)
        {
            return $"{item.Name}";
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = CustomerComboBox.SelectedIndex;

            if (index == -1) return;

            SelectedCustomer = _customers[index];

            if (SelectedCustomer.Cart.Items == null) return;

            AmountDigitLabel.Text = SelectedCustomer.Cart.Amount.ToString();
            UpdateCartListBox(-1);
            UpdateDiscountCheckedListBox();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            int indexofListBox = ItemsListBox.SelectedIndex;
            int indexofComboBox = CustomerComboBox.SelectedIndex;

            if (indexofListBox == -1 || indexofComboBox == -1) return;

            SelectedCustomer.Cart.Items.Add(_items[indexofListBox]);

            AmountDigitLabel.Text = SelectedCustomer.Cart.Amount.ToString();

            UpdateCartListBox(-1);
            UpdateDiscountAmount();
            CreateOrderButton.Enabled = true;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int indexofComboBox = CustomerComboBox.SelectedIndex;
            int indexofListBox = CartListBox.SelectedIndex;

            if (indexofListBox == -1 || indexofComboBox == -1) return;

            SelectedCustomer.Cart.Items.RemoveAt(indexofListBox);
            AmountDigitLabel.Text = SelectedCustomer.Cart.Amount.ToString();

            UpdateCartListBox(-1);
            UpdateDiscountAmount();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            SelectedCustomer.Cart = new Cart();
            UpdateCartListBox(-1);
            AmountDigitLabel.Text = SelectedCustomer.Cart.Amount.ToString();
            UpdateDiscountAmount();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Order order;

            if (SelectedCustomer.IsPrioritized)
            {
                order = new PriorityOrder();
            }
            else
            {
                order = new Order();
            }

            order.Address = SelectedCustomer.Address;
            order.Items = SelectedCustomer.Cart.Items;
            order.Status = OrderStatus.New;

            double discountAmount = 0;
            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += SelectedCustomer.Discounts[i].Calculate(SelectedCustomer.Cart.Items);
                }
            }
            order.DiscountAmount = discountAmount;
            SelectedCustomer.Orders.Add(order);

            for (int i = 0; i < DiscountCheckedListBox.Items.Count; i++)
            {
                if (DiscountCheckedListBox.GetItemChecked(i))
                {
                    SelectedCustomer.Discounts[i].Apply(SelectedCustomer.Cart.Items);
                }
                SelectedCustomer.Discounts[i].Update(SelectedCustomer.Cart.Items);
            }
            UpdateDiscountCheckedListBox();
            SelectedCustomer.Cart = new Cart();
            UpdateCartListBox(-1);
            AmountDigitLabel.Text = SelectedCustomer.Cart.Amount.ToString();

            CreateOrderButton.Enabled = false;
        }

        private void DiscountCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountAmount();
        }
    }
}
