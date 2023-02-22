using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Коллекция товаров по введенной подстроке.
        /// </summary>
        private List<Item> _displayItems;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _selectedItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
                CategoryComboBox.Items.Add(value);

            OrderByComboBox.Items.AddRange(new string[]
            {
                "Name (Ascending)",
                "Cost (Ascending)",
                "Cost (Descending)"
            });
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
                _displayItems = value;

                if (_items != null)
                {
                    UpdateListBox(_displayItems, -1);
                    OrderByComboBox.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Очищает поля вывода информации.
        /// </summary>
        private void ClearAllFields()
        {
            IDTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
        }

        /// <summary>
        /// Ищет индекс элемента по уникальному идентификатору.
        /// </summary>
        /// <returns>Возвращает индекс найденного элемента.</returns>
        private int FindItemIndexById()
        {
            int currentItemId = _selectedItem.Id;
            int index = -1;

            for (int i = 0; i < _displayItems.Count; i++)
            {
                if (_displayItems[i].Id != currentItemId) continue;

                index = i;
                break;
            }

            return index;
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateListBox(List<Item> itemList, int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in itemList)
            {
                ItemsListBox.Items.Add(FormatText(item));
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Приводит текст к нужному формату.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Возвращает отформатированный текст.</returns>
        private string FormatText(Item item)
        {
            return $"{item.Name}";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.Randomize();
            _selectedItem = item;
            _items.Add(item);
            _displayItems = _items;
            UpdateListBox(_displayItems, 0);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            _displayItems = _items;
            UpdateListBox(_displayItems, -1);

            ClearAllFields();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _selectedItem = _displayItems[index];

            IDTextBox.Text = _selectedItem.Id.ToString();
            CostTextBox.Text = _selectedItem.Cost.ToString();
            NameTextBox.Text = _selectedItem.Name;
            InfoTextBox.Text = _selectedItem.Info;
            CategoryComboBox.SelectedIndex = (int)_selectedItem.Category;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                int cost = Convert.ToInt32(CostTextBox.Text);
                _selectedItem.Cost = cost;
            }
            catch
            {
                CostTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            CostTextBox.BackColor = AppColor.CorrectColor;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string name = NameTextBox.Text;
                _selectedItem.Name = name;

                int indexofItem = FindItemIndexById();
                UpdateListBox(_displayItems, indexofItem);
            }
            catch
            {
                NameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            NameTextBox.BackColor = AppColor.CorrectColor;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string info = InfoTextBox.Text;
                _selectedItem.Info = info;
            }
            catch
            {
                InfoTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            InfoTextBox.BackColor = AppColor.CorrectColor;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexofCategory = CategoryComboBox.SelectedIndex;
            int indexofListBox = ItemsListBox.SelectedIndex;

            if ((indexofCategory == -1) || (indexofListBox == -1)) return;

            _selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            string find = FindTextBox.Text;

            if (find != "")
            {
                _displayItems = DataTools.Find(_items,
                    item => item.Name.ToLower().Contains(find.ToLower()));
                UpdateListBox(_displayItems, -1);
            }
            else
            {
                _displayItems = _items;
                UpdateListBox(_displayItems, -1);
            }
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = OrderByComboBox.SelectedIndex;

            switch (index)
            {
                case 0:
                    DataTools.Sort(_items, (item, item1) =>
                        Compare(item.Name, item1.Name, StringComparison.Ordinal) <= 0);
                    break;
                case 1:
                    DataTools.Sort(_items, (item, item1) =>
                        item.CompareTo(item1) <= 0);
                    break;
                case 2:
                    DataTools.Sort(_items, (item, item1) =>
                        item.CompareTo(item1) >= 0);
                    break;
            }

            _displayItems = _items;
            UpdateListBox(_displayItems, -1);
        }
    }
}
