
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditCustomerButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsPanel.Controls.Add(this.AddressTextBox);
            this.ItemsPanel.Controls.Add(this.FullNameTextBox);
            this.ItemsPanel.Controls.Add(this.IDTextBox);
            this.ItemsPanel.Controls.Add(this.NameLabel);
            this.ItemsPanel.Controls.Add(this.CostLabel);
            this.ItemsPanel.Controls.Add(this.IDLabel);
            this.ItemsPanel.Controls.Add(this.label2);
            this.ItemsPanel.Location = new System.Drawing.Point(330, 3);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(429, 197);
            this.ItemsPanel.TabIndex = 11;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(73, 83);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(353, 110);
            this.AddressTextBox.TabIndex = 6;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(73, 51);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(353, 23);
            this.FullNameTextBox.TabIndex = 5;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(73, 22);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.ReadOnly = true;
            this.IDTextBox.Size = new System.Drawing.Size(100, 23);
            this.IDTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 86);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Address:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 56);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(64, 15);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 25);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 15);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Customer";
            // 
            // EditCustomerButton
            // 
            this.EditCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditCustomerButton.Location = new System.Drawing.Point(221, 453);
            this.EditCustomerButton.Name = "EditCustomerButton";
            this.EditCustomerButton.Size = new System.Drawing.Size(103, 40);
            this.EditCustomerButton.TabIndex = 10;
            this.EditCustomerButton.Text = "Edit";
            this.EditCustomerButton.UseVisualStyleBackColor = true;
            this.EditCustomerButton.Click += new System.EventHandler(this.EditCustomerButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveCustomerButton.Location = new System.Drawing.Point(112, 453);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(103, 40);
            this.RemoveCustomerButton.TabIndex = 9;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddCustomerButton.Location = new System.Drawing.Point(3, 453);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(103, 40);
            this.AddCustomerButton.TabIndex = 8;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 15;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 23);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(321, 424);
            this.CustomersListBox.TabIndex = 7;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(330, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 291);
            this.panel1.TabIndex = 12;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ItemsPanel);
            this.Controls.Add(this.EditCustomerButton);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.label1);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(763, 497);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditCustomerButton;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
