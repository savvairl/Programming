
namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.EditItemButton = new System.Windows.Forms.Button();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 15;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 23);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(321, 424);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddItemButton.Location = new System.Drawing.Point(3, 453);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(103, 40);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Add";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveItemButton.Location = new System.Drawing.Point(112, 453);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(103, 40);
            this.RemoveItemButton.TabIndex = 3;
            this.RemoveItemButton.Text = "Remove";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // EditItemButton
            // 
            this.EditItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditItemButton.Location = new System.Drawing.Point(221, 453);
            this.EditItemButton.Name = "EditItemButton";
            this.EditItemButton.Size = new System.Drawing.Size(103, 40);
            this.EditItemButton.TabIndex = 4;
            this.EditItemButton.Text = "Edit";
            this.EditItemButton.UseVisualStyleBackColor = true;
            this.EditItemButton.Click += new System.EventHandler(this.EditItemButton_Click);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsPanel.Controls.Add(this.InfoTextBox);
            this.ItemsPanel.Controls.Add(this.DescriptionLabel);
            this.ItemsPanel.Controls.Add(this.NameTextBox);
            this.ItemsPanel.Controls.Add(this.CostTextBox);
            this.ItemsPanel.Controls.Add(this.IDTextBox);
            this.ItemsPanel.Controls.Add(this.NameLabel);
            this.ItemsPanel.Controls.Add(this.CostLabel);
            this.ItemsPanel.Controls.Add(this.IDLabel);
            this.ItemsPanel.Controls.Add(this.label2);
            this.ItemsPanel.Location = new System.Drawing.Point(330, 3);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(429, 490);
            this.ItemsPanel.TabIndex = 5;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(3, 247);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(423, 147);
            this.InfoTextBox.TabIndex = 8;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 229);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(3, 104);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(423, 117);
            this.NameTextBox.TabIndex = 6;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(43, 53);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 23);
            this.CostTextBox.TabIndex = 5;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(43, 22);
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
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 56);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 15);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
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
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Item";
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsPanel);
            this.Controls.Add(this.EditItemButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.label1);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(763, 497);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button EditItemButton;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label2;
    }
}
