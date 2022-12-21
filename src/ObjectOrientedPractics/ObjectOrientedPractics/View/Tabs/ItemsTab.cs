using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

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
                    UpdateListBox(-1);
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
            var orderedListItems = from item in _items
                                   orderby item.Name
                                   select item;

            _items = orderedListItems.ToList();
            int currentItemId = _selectedItem.Id;
            int index = -1;

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id != currentItemId) continue;

                index = i;
                break;
            }

            return index;
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear()
                ;
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
            UpdateListBox(0);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            UpdateListBox(-1);

            ClearAllFields();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _selectedItem = _items[index];

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
                UpdateListBox(indexofItem);
            }
            catch
            {
                NameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            NameTextBox.BackColor = AppColor.CorrectColor;
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
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexofCategory = CategoryComboBox.SelectedIndex;
            int indexofListBox = ItemsListBox.SelectedIndex;

            if ((indexofCategory == -1) || (indexofListBox == -1)) return;

            _selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
        }
    }
}
