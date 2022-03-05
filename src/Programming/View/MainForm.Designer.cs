
namespace Programming.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SeasonGB = new System.Windows.Forms.GroupBox();
            this.SeasonChooseButton = new System.Windows.Forms.Button();
            this.SeasonChooseCombobox = new System.Windows.Forms.ComboBox();
            this.SeasonChooseLabel = new System.Windows.Forms.Label();
            this.WeekParseGB = new System.Windows.Forms.GroupBox();
            this.WeekParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsingValueLabel = new System.Windows.Forms.Label();
            this.ParsingValueTextbox = new System.Windows.Forms.TextBox();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBoxLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumerationsGB = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SeasonGB.SuspendLayout();
            this.WeekParseGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SeasonGB);
            this.tabPage1.Controls.Add(this.WeekParseGB);
            this.tabPage1.Controls.Add(this.ValuesTextBox);
            this.tabPage1.Controls.Add(this.ValueTextBoxLabel);
            this.tabPage1.Controls.Add(this.ValueLabel);
            this.tabPage1.Controls.Add(this.EnumsLabel);
            this.tabPage1.Controls.Add(this.ValuesListBox);
            this.tabPage1.Controls.Add(this.EnumsListBox);
            this.tabPage1.Controls.Add(this.EnumerationsGB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonGB
            // 
            this.SeasonGB.Controls.Add(this.SeasonChooseButton);
            this.SeasonGB.Controls.Add(this.SeasonChooseCombobox);
            this.SeasonGB.Controls.Add(this.SeasonChooseLabel);
            this.SeasonGB.Location = new System.Drawing.Point(351, 247);
            this.SeasonGB.Name = "SeasonGB";
            this.SeasonGB.Size = new System.Drawing.Size(438, 174);
            this.SeasonGB.TabIndex = 8;
            this.SeasonGB.TabStop = false;
            this.SeasonGB.Text = "Season Handle";
            // 
            // SeasonChooseButton
            // 
            this.SeasonChooseButton.Location = new System.Drawing.Point(205, 69);
            this.SeasonChooseButton.Name = "SeasonChooseButton";
            this.SeasonChooseButton.Size = new System.Drawing.Size(75, 20);
            this.SeasonChooseButton.TabIndex = 3;
            this.SeasonChooseButton.Text = "Go!";
            this.SeasonChooseButton.UseVisualStyleBackColor = true;
            this.SeasonChooseButton.Click += new System.EventHandler(this.SeasonChooseButton_Click);
            // 
            // SeasonChooseCombobox
            // 
            this.SeasonChooseCombobox.FormattingEnabled = true;
            this.SeasonChooseCombobox.Location = new System.Drawing.Point(6, 68);
            this.SeasonChooseCombobox.Name = "SeasonChooseCombobox";
            this.SeasonChooseCombobox.Size = new System.Drawing.Size(193, 21);
            this.SeasonChooseCombobox.TabIndex = 2;
            // 
            // SeasonChooseLabel
            // 
            this.SeasonChooseLabel.AutoSize = true;
            this.SeasonChooseLabel.Location = new System.Drawing.Point(6, 53);
            this.SeasonChooseLabel.Name = "SeasonChooseLabel";
            this.SeasonChooseLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonChooseLabel.TabIndex = 1;
            this.SeasonChooseLabel.Text = "Choose season:";
            // 
            // WeekParseGB
            // 
            this.WeekParseGB.Controls.Add(this.WeekParseLabel);
            this.WeekParseGB.Controls.Add(this.ParseButton);
            this.WeekParseGB.Controls.Add(this.ParsingValueLabel);
            this.WeekParseGB.Controls.Add(this.ParsingValueTextbox);
            this.WeekParseGB.Location = new System.Drawing.Point(3, 247);
            this.WeekParseGB.Name = "WeekParseGB";
            this.WeekParseGB.Size = new System.Drawing.Size(332, 174);
            this.WeekParseGB.TabIndex = 7;
            this.WeekParseGB.TabStop = false;
            this.WeekParseGB.Text = "Weekday Parsing";
            // 
            // WeekParseLabel
            // 
            this.WeekParseLabel.AutoSize = true;
            this.WeekParseLabel.Location = new System.Drawing.Point(7, 98);
            this.WeekParseLabel.Name = "WeekParseLabel";
            this.WeekParseLabel.Size = new System.Drawing.Size(130, 13);
            this.WeekParseLabel.TabIndex = 3;
            this.WeekParseLabel.Text = "Это день недели ( .. = .. )";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(205, 69);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 21);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParsingValueLabel
            // 
            this.ParsingValueLabel.AutoSize = true;
            this.ParsingValueLabel.Location = new System.Drawing.Point(6, 54);
            this.ParsingValueLabel.Name = "ParsingValueLabel";
            this.ParsingValueLabel.Size = new System.Drawing.Size(115, 13);
            this.ParsingValueLabel.TabIndex = 1;
            this.ParsingValueLabel.Text = "Type value for parsing:";
            // 
            // ParsingValueTextbox
            // 
            this.ParsingValueTextbox.Location = new System.Drawing.Point(6, 70);
            this.ParsingValueTextbox.Name = "ParsingValueTextbox";
            this.ParsingValueTextbox.Size = new System.Drawing.Size(193, 20);
            this.ParsingValueTextbox.TabIndex = 0;
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Location = new System.Drawing.Point(351, 42);
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValuesTextBox.TabIndex = 2;
            // 
            // ValueTextBoxLabel
            // 
            this.ValueTextBoxLabel.AutoSize = true;
            this.ValueTextBoxLabel.Location = new System.Drawing.Point(348, 26);
            this.ValueTextBoxLabel.Name = "ValueTextBoxLabel";
            this.ValueTextBoxLabel.Size = new System.Drawing.Size(51, 13);
            this.ValueTextBoxLabel.TabIndex = 5;
            this.ValueTextBoxLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(183, 26);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 4;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(18, 26);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsLabel.TabIndex = 3;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(186, 42);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(149, 173);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.AccessibleName = "";
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(21, 42);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(149, 173);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // EnumerationsGB
            // 
            this.EnumerationsGB.Location = new System.Drawing.Point(3, 6);
            this.EnumerationsGB.Name = "EnumerationsGB";
            this.EnumerationsGB.Size = new System.Drawing.Size(786, 235);
            this.EnumerationsGB.TabIndex = 6;
            this.EnumerationsGB.TabStop = false;
            this.EnumerationsGB.Text = "Enumerations";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SeasonGB.ResumeLayout(false);
            this.SeasonGB.PerformLayout();
            this.WeekParseGB.ResumeLayout(false);
            this.WeekParseGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label ValueTextBoxLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.TextBox ValuesTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumerationsGB;
        private System.Windows.Forms.GroupBox SeasonGB;
        private System.Windows.Forms.Button SeasonChooseButton;
        private System.Windows.Forms.ComboBox SeasonChooseCombobox;
        private System.Windows.Forms.Label SeasonChooseLabel;
        private System.Windows.Forms.GroupBox WeekParseGB;
        private System.Windows.Forms.Label WeekParseLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label ParsingValueLabel;
        private System.Windows.Forms.TextBox ParsingValueTextbox;
    }
}

