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
    /// <summary>
    /// Предоставляет реализацию по представлению вкладки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Путь до директории AppData.
        /// </summary>
        private string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _selectedItem;

        /// <summary>
        /// Окно добавления товара.
        /// </summary>
        private AddItemForm _addItemForm;

        /// <summary>
        /// Окно редактирования товара.
        /// </summary>
        private EditItemForm _editItemForm;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _items = ItemSerializer.Deserialize(AppDataPath);
            UpdateListBox(-1);
        }

        /// <summary>
        /// Очищает все поля.
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
            int index = _items.IndexOf(_selectedItem);
            return index;
        }

        /// <summary>
        /// Обновляет данные в списке ListBox.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name} - {item.Cost}");
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _addItemForm = new AddItemForm();

            if (_addItemForm.ShowDialog() != DialogResult.OK) return;

            _items.Add(ItemData.Item);
            ItemSerializer.Serialize(AppDataPath, _items);
            UpdateListBox(0);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            UpdateListBox(-1);
            ClearAllFields();
            ItemSerializer.Serialize(AppDataPath, _items);
        }

        private void EditItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            ItemData.Item = _selectedItem;

            _editItemForm = new EditItemForm();

            if (_editItemForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _selectedItem = ItemData.Item;

            int index = FindItemIndexById();
            UpdateListBox(index);
            ItemSerializer.Serialize(AppDataPath, _items);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _selectedItem = _items[index];
            CostTextBox.Text = _selectedItem.Cost.ToString();
            NameTextBox.Text = _selectedItem.Name;
            InfoTextBox.Text = _selectedItem.Info;
            IDTextBox.Text = _selectedItem.Id.ToString();
        }
    }
}
