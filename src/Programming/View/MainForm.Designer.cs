
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonChooseButton = new System.Windows.Forms.Button();
            this.SeasonChooseCombobox = new System.Windows.Forms.ComboBox();
            this.SeasonChooseLabel = new System.Windows.Forms.Label();
            this.WeekParseGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekParseLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsingValueLabel = new System.Windows.Forms.Label();
            this.ParsingValueTextbox = new System.Windows.Forms.TextBox();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.ValueTextBoxLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumerationsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesFindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekParseGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SeasonGroupBox);
            this.tabPage1.Controls.Add(this.WeekParseGroupBox);
            this.tabPage1.Controls.Add(this.ValuesTextBox);
            this.tabPage1.Controls.Add(this.ValueTextBoxLabel);
            this.tabPage1.Controls.Add(this.ValueLabel);
            this.tabPage1.Controls.Add(this.EnumsLabel);
            this.tabPage1.Controls.Add(this.ValuesListBox);
            this.tabPage1.Controls.Add(this.EnumerationsGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(688, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseCombobox);
            this.SeasonGroupBox.Controls.Add(this.SeasonChooseLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(351, 247);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(337, 86);
            this.SeasonGroupBox.TabIndex = 8;
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
            // WeekParseGroupBox
            // 
            this.WeekParseGroupBox.Controls.Add(this.WeekParseLabel);
            this.WeekParseGroupBox.Controls.Add(this.ParseButton);
            this.WeekParseGroupBox.Controls.Add(this.ParsingValueLabel);
            this.WeekParseGroupBox.Controls.Add(this.ParsingValueTextbox);
            this.WeekParseGroupBox.Location = new System.Drawing.Point(0, 247);
            this.WeekParseGroupBox.Name = "WeekParseGroupBox";
            this.WeekParseGroupBox.Size = new System.Drawing.Size(335, 86);
            this.WeekParseGroupBox.TabIndex = 7;
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
            // ParsingValueLabel
            // 
            this.ParsingValueLabel.AutoSize = true;
            this.ParsingValueLabel.Location = new System.Drawing.Point(18, 19);
            this.ParsingValueLabel.Name = "ParsingValueLabel";
            this.ParsingValueLabel.Size = new System.Drawing.Size(115, 13);
            this.ParsingValueLabel.TabIndex = 1;
            this.ParsingValueLabel.Text = "Type value for parsing:";
            // 
            // ParsingValueTextbox
            // 
            this.ParsingValueTextbox.Location = new System.Drawing.Point(21, 35);
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
            // EnumerationsGroupBox
            // 
            this.EnumerationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationsGroupBox.Location = new System.Drawing.Point(0, 6);
            this.EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            this.EnumerationsGroupBox.Size = new System.Drawing.Size(688, 235);
            this.EnumerationsGroupBox.TabIndex = 6;
            this.EnumerationsGroupBox.TabStop = false;
            this.EnumerationsGroupBox.Text = "Enumerations";
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MovieGroupBox);
            this.tabPage2.Controls.Add(this.ClassesGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(688, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.MovieFindButton);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.DurationTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationLabel);
            this.MovieGroupBox.Controls.Add(this.ReleaseTextBox);
            this.MovieGroupBox.Controls.Add(this.ReleaseLabel);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.NameTextBox);
            this.MovieGroupBox.Controls.Add(this.NameLabel);
            this.MovieGroupBox.Location = new System.Drawing.Point(352, 6);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(336, 327);
            this.MovieGroupBox.TabIndex = 1;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(161, 290);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(148, 23);
            this.MovieFindButton.TabIndex = 11;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(161, 195);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(148, 20);
            this.RatingTextBox.TabIndex = 10;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(158, 179);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 9;
            this.RatingLabel.Text = "Rating:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(161, 156);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(148, 20);
            this.DurationTextBox.TabIndex = 8;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(158, 140);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(50, 13);
            this.DurationLabel.TabIndex = 7;
            this.DurationLabel.Text = "Duration:";
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.Location = new System.Drawing.Point(161, 117);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.Size = new System.Drawing.Size(148, 20);
            this.ReleaseTextBox.TabIndex = 6;
            this.ReleaseTextBox.TextChanged += new System.EventHandler(this.ReleaseTextBox_TextChanged);
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(158, 101);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(72, 13);
            this.ReleaseLabel.TabIndex = 5;
            this.ReleaseLabel.Text = "Release year:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(18, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(123, 290);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(158, 62);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(161, 78);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(148, 20);
            this.GenreTextBox.TabIndex = 3;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(161, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(158, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.RectanglesFindButton);
            this.ClassesGroupBox.Controls.Add(this.ColorTextBox);
            this.ClassesGroupBox.Controls.Add(this.WidthTextBox);
            this.ClassesGroupBox.Controls.Add(this.LengthTextBox);
            this.ClassesGroupBox.Controls.Add(this.ColorLabel);
            this.ClassesGroupBox.Controls.Add(this.WidthLabel);
            this.ClassesGroupBox.Controls.Add(this.LengthLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(0, 6);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(338, 327);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // RectanglesFindButton
            // 
            this.RectanglesFindButton.Location = new System.Drawing.Point(160, 290);
            this.RectanglesFindButton.Name = "RectanglesFindButton";
            this.RectanglesFindButton.Size = new System.Drawing.Size(148, 23);
            this.RectanglesFindButton.TabIndex = 7;
            this.RectanglesFindButton.Text = "Find";
            this.RectanglesFindButton.UseVisualStyleBackColor = true;
            this.RectanglesFindButton.Click += new System.EventHandler(this.RectanglesFindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(160, 117);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(148, 20);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(160, 78);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(148, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(160, 39);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(148, 20);
            this.LengthTextBox.TabIndex = 4;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(157, 101);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 3;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(157, 62);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(157, 23);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(20, 23);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(123, 290);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 359);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekParseGroupBox.ResumeLayout(false);
            this.WeekParseGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox EnumerationsGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonChooseButton;
        private System.Windows.Forms.ComboBox SeasonChooseCombobox;
        private System.Windows.Forms.Label SeasonChooseLabel;
        private System.Windows.Forms.GroupBox WeekParseGroupBox;
        private System.Windows.Forms.Label WeekParseLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label ParsingValueLabel;
        private System.Windows.Forms.TextBox ParsingValueTextbox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.GroupBox ClassesGroupBox;
        private System.Windows.Forms.Button RectanglesFindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}

