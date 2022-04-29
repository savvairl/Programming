
namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.ParsingValueLabel = new System.Windows.Forms.Label();
            this.WeekParseGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsingValueTextbox = new System.Windows.Forms.TextBox();
            this.WeekParseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParsingValueLabel
            // 
            this.ParsingValueLabel.AutoSize = true;
            this.ParsingValueLabel.Location = new System.Drawing.Point(18, 19);
            this.ParsingValueLabel.Name = "ParsingValueLabel";
            this.ParsingValueLabel.Size = new System.Drawing.Size(115, 13);
            this.ParsingValueLabel.TabIndex = 1;
            this.ParsingValueLabel.Text = "Type value for parsing:";
            // 
            // WeekParseGroupBox
            // 
            this.WeekParseGroupBox.Controls.Add(this.WeekParseLabel);
            this.WeekParseGroupBox.Controls.Add(this.ParseButton);
            this.WeekParseGroupBox.Controls.Add(this.ParsingValueLabel);
            this.WeekParseGroupBox.Controls.Add(this.ParsingValueTextbox);
            this.WeekParseGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekParseGroupBox.Name = "WeekParseGroupBox";
            this.WeekParseGroupBox.Size = new System.Drawing.Size(335, 86);
            this.WeekParseGroupBox.TabIndex = 8;
            this.WeekParseGroupBox.TabStop = false;
            this.WeekParseGroupBox.Text = "Weekday Parsing";
            // 
            // WeekParseLabel
            // 
            this.WeekParseLabel.AutoSize = true;
            this.WeekParseLabel.Location = new System.Drawing.Point(18, 58);
            this.WeekParseLabel.Name = "WeekParseLabel";
            this.WeekParseLabel.Size = new System.Drawing.Size(130, 13);
            this.WeekParseLabel.TabIndex = 3;
            this.WeekParseLabel.Text = "Это день недели ( .. = .. )";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(220, 34);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 22);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParsingValueTextbox
            // 
            this.ParsingValueTextbox.Location = new System.Drawing.Point(21, 35);
            this.ParsingValueTextbox.Name = "ParsingValueTextbox";
            this.ParsingValueTextbox.Size = new System.Drawing.Size(193, 20);
            this.ParsingValueTextbox.TabIndex = 0;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekParseGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(343, 95);
            this.WeekParseGroupBox.ResumeLayout(false);
            this.WeekParseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ParsingValueLabel;
        private System.Windows.Forms.GroupBox WeekParseGroupBox;
        private System.Windows.Forms.Label WeekParseLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParsingValueTextbox;
    }
}
