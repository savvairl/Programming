
namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBoxLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.AccessibleName = "";
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(21, 36);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(149, 173);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Location = new System.Drawing.Point(351, 36);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValuesTextBox.TabIndex = 8;
            // 
            // ValueTextBoxLabel
            // 
            this.ValueTextBoxLabel.AutoSize = true;
            this.ValueTextBoxLabel.Location = new System.Drawing.Point(348, 20);
            this.ValueTextBoxLabel.Name = "ValueTextBoxLabel";
            this.ValueTextBoxLabel.Size = new System.Drawing.Size(51, 13);
            this.ValueTextBoxLabel.TabIndex = 11;
            this.ValueTextBoxLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(183, 20);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(18, 20);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsLabel.TabIndex = 9;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(186, 36);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(149, 173);
            this.ValuesListBox.TabIndex = 7;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(688, 235);
            this.EnumerationsGroupBox.TabIndex = 12;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ValuesTextBox);
            this.Controls.Add(this.ValueTextBoxLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.EnumsLabel);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumerationsGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(688, 240);
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox ValuesTextBox;
        private System.Windows.Forms.Label ValueTextBoxLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
    }
}
