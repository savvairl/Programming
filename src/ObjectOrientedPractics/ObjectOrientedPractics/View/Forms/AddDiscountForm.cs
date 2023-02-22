using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();

            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }

            CategoryComboBox.SelectedIndex = 0;
        }

        public PercentDiscount PercentDiscount { get; set; }

        private void OKButton_Click(object sender, EventArgs e)
        {
            PercentDiscount discount = new PercentDiscount((Category)CategoryComboBox.SelectedItem);
            PercentDiscount = discount;

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
