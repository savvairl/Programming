
namespace Programming.View.Controls
{
    partial class SeasonHandleControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonChooseButton = new System.Windows.Forms.Button();
            this.SeasonChooseCombobox = new System.Windows.Forms.ComboBox();
            this.SeasonChooseLabel = new System.Windows.Forms.Label();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseCombobox);
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(337, 86);
            this.SeasonGroupBox.TabIndex = 9;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonChooseButton
            // 
            this.SeasonChooseButton.Location = new System.Drawing.Point(220, 34);
            this.SeasonChooseButton.Name = "SeasonChooseButton";
            this.SeasonChooseButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonChooseButton.TabIndex = 3;
            this.SeasonChooseButton.Text = "Go!";
            this.SeasonChooseButton.UseVisualStyleBackColor = true;
            this.SeasonChooseButton.Click += new System.EventHandler(this.SeasonChooseButton_Click);
            // 
            // SeasonChooseCombobox
            // 
            this.SeasonChooseCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonChooseCombobox.FormattingEnabled = true;
            this.SeasonChooseCombobox.Location = new System.Drawing.Point(21, 35);
            this.SeasonChooseCombobox.Name = "SeasonChooseCombobox";
            this.SeasonChooseCombobox.Size = new System.Drawing.Size(193, 21);
            this.SeasonChooseCombobox.TabIndex = 2;
            // 
            // SeasonChooseLabel
            // 
            this.SeasonChooseLabel.AutoSize = true;
            this.SeasonChooseLabel.Location = new System.Drawing.Point(18, 19);
            this.SeasonChooseLabel.Name = "SeasonChooseLabel";
            this.SeasonChooseLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonChooseLabel.TabIndex = 1;
            this.SeasonChooseLabel.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(340, 89);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonChooseButton;
        private System.Windows.Forms.ComboBox SeasonChooseCombobox;
        private System.Windows.Forms.Label SeasonChooseLabel;
    }
}
