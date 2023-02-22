using System.Windows.Forms;
using System;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>  
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = Serializer.Deserialize();
            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;
            priorityOrdersTab1.Items = _store.Items;
            itemsTab1.ItemsChanged += ItemsTab_ItemsChanged;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = itemsTab1.Items;
            _store.Customers = customersTab1.Customers;
            Serializer.Serialize(_store);
        }

        private void ItemsTab_ItemsChanged(object sender, EventArgs args)
        {
            cartsTab1.Items = itemsTab1.Items;
            cartsTab1.Customers = customersTab1.Customers;
            ordersTab1.Customers = cartsTab1.Customers;
            ordersTab1.RefreshData();
            cartsTab1.RefreshData();
        }
    }
}
