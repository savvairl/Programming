
namespace ObjectOrientedPractics.View
{
    partial class EditItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditItemForm));
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemsPanel.Controls.Add(this.CancelButton);
            this.ItemsPanel.Controls.Add(this.OKButton);
            this.ItemsPanel.Controls.Add(this.InfoTextBox);
            this.ItemsPanel.Controls.Add(this.DescriptionLabel);
            this.ItemsPanel.Controls.Add(this.NameTextBox);
            this.ItemsPanel.Controls.Add(this.CostTextBox);
            this.ItemsPanel.Controls.Add(this.NameLabel);
            this.ItemsPanel.Controls.Add(this.CostLabel);
            this.ItemsPanel.Controls.Add(this.label2);
            this.ItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(429, 405);
            this.ItemsPanel.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.Location = new System.Drawing.Point(84, 350);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 43);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OKButton.Location = new System.Drawing.Point(3, 350);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 43);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(3, 204);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(423, 140);
            this.InfoTextBox.TabIndex = 8;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 186);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(3, 66);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(423, 117);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(43, 22);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 23);
            this.CostTextBox.TabIndex = 5;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 25);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(34, 15);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edit Item";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 405);
            this.Controls.Add(this.ItemsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
    }
}