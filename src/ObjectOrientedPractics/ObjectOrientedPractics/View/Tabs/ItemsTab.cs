using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private Item _item;

        private List<Item> _items;

        private Item _selectedItem;

        private AddItemForm _addItemForm;

        private EditItemForm _editItemForm;

        public ItemsTab()
        {
            InitializeComponent();

            _item = new Item();
            UpdateListBox(-1);
        }

        private void ClearAllFields()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        private void SortList()
        {
            var orderedItemList = from item in _items
                                   orderby item.Name, item.Cost
                                   select item;
            _items = orderedItemList.ToList();
        }

        private int FindItemIndexById()
        {
            SortList();
            int index = _items.IndexOf(_selectedItem);
            return index;
        }

        private void UpdateListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            SortList();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name} - {item.Cost}");
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _addItemForm = new AddItemForm();

            _items.Add(ItemData.Item);
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

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            ItemData.Item = _selectedItem;

            _editItemForm = new EditItemForm();

            _selectedItem = ItemData.Item;

            int index = FindItemIndexById();
            UpdateListBox(index);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _selectedItem = _items[index];
            CostTextBox.Text = _selectedItem.Cost.ToString();
            NameTextBox.Text = _selectedItem.Name;
            DescriptionTextBox.Text = _selectedItem.Info;
        }
    }
}
