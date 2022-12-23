
namespace ObjectOrientedPractics.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CartsPage = new System.Windows.Forms.TabPage();
            this.cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.CustomersPage = new System.Windows.Forms.TabPage();
            this.customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.ItemsPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.PriorityOrdersPage = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.CartsPage.SuspendLayout();
            this.CustomersPage.SuspendLayout();
            this.ItemsPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.PriorityOrdersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // CartsPage
            // 
            this.CartsPage.Controls.Add(this.cartsTab1);
            this.CartsPage.Location = new System.Drawing.Point(4, 22);
            this.CartsPage.Name = "CartsPage";
            this.CartsPage.Size = new System.Drawing.Size(813, 505);
            this.CartsPage.TabIndex = 2;
            this.CartsPage.Text = "Carts";
            this.CartsPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            this.cartsTab1.Customers = null;
            this.cartsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab1.Items = null;
            this.cartsTab1.Location = new System.Drawing.Point(0, 0);
            this.cartsTab1.Name = "cartsTab1";
            this.cartsTab1.Size = new System.Drawing.Size(813, 505);
            this.cartsTab1.TabIndex = 0;
            // 
            // CustomersPage
            // 
            this.CustomersPage.Controls.Add(this.customersTab1);
            this.CustomersPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersPage.Name = "CustomersPage";
            this.CustomersPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersPage.Size = new System.Drawing.Size(813, 505);
            this.CustomersPage.TabIndex = 1;
            this.CustomersPage.Text = "Customers";
            this.CustomersPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            this.customersTab1.Customers = null;
            this.customersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab1.Location = new System.Drawing.Point(3, 3);
            this.customersTab1.Name = "customersTab1";
            this.customersTab1.Size = new System.Drawing.Size(807, 499);
            this.customersTab1.TabIndex = 0;
            // 
            // ItemsPage
            // 
            this.ItemsPage.Controls.Add(this.itemsTab1);
            this.ItemsPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsPage.Name = "ItemsPage";
            this.ItemsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsPage.Size = new System.Drawing.Size(813, 505);
            this.ItemsPage.TabIndex = 0;
            this.ItemsPage.Text = "Items";
            this.ItemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Items = null;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(807, 499);
            this.itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ItemsPage);
            this.tabControl1.Controls.Add(this.CustomersPage);
            this.tabControl1.Controls.Add(this.CartsPage);
            this.tabControl1.Controls.Add(this.OrdersPage);
            this.tabControl1.Controls.Add(this.PriorityOrdersPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.ordersTab1);
            this.OrdersPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Size = new System.Drawing.Size(813, 505);
            this.OrdersPage.TabIndex = 3;
            this.OrdersPage.Text = "Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            this.ordersTab1.Customers = null;
            this.ordersTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab1.Location = new System.Drawing.Point(0, 0);
            this.ordersTab1.Name = "ordersTab1";
            this.ordersTab1.Size = new System.Drawing.Size(813, 505);
            this.ordersTab1.TabIndex = 0;
            // 
            // PriorityOrdersPage
            // 
            this.PriorityOrdersPage.Controls.Add(this.priorityOrdersTab1);
            this.PriorityOrdersPage.Location = new System.Drawing.Point(4, 22);
            this.PriorityOrdersPage.Name = "PriorityOrdersPage";
            this.PriorityOrdersPage.Size = new System.Drawing.Size(813, 505);
            this.PriorityOrdersPage.TabIndex = 4;
            this.PriorityOrdersPage.Text = "Priority Orders";
            this.PriorityOrdersPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Items = null;
            this.priorityOrdersTab1.Location = new System.Drawing.Point(3, 2);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(807, 500);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "ObjectOrientedPractics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.CartsPage.ResumeLayout(false);
            this.CustomersPage.ResumeLayout(false);
            this.ItemsPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.PriorityOrdersPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CartsPage;
        private Tabs.CartsTab cartsTab1;
        private System.Windows.Forms.TabPage CustomersPage;
        private Tabs.CustomersTab customersTab1;
        private System.Windows.Forms.TabPage ItemsPage;
        private Tabs.ItemsTab itemsTab1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrdersPage;
        private Tabs.OrdersTab ordersTab1;
        private System.Windows.Forms.TabPage PriorityOrdersPage;
        private Tabs.PriorityOrdersTab priorityOrdersTab1;
    }
}

