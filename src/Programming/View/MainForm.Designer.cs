
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabControl = new System.Windows.Forms.TabPage();
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
            this.ClassesTabControl = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.ReleaseTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.RectanglesFindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabControl = new System.Windows.Forms.TabPage();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.SelectedRectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleYTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleXTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleHeightLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleWidthLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleYLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleXLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleIdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.RectanglesListBox2 = new System.Windows.Forms.ListBox();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.EnumsTabControl.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekParseGroupBox.SuspendLayout();
            this.EnumerationsGroupBox.SuspendLayout();
            this.ClassesTabControl.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.RectanglesTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabControl);
            this.TabControl.Controls.Add(this.ClassesTabControl);
            this.TabControl.Controls.Add(this.RectanglesTabControl);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(696, 359);
            this.TabControl.TabIndex = 0;
            // 
            // EnumsTabControl
            // 
            this.EnumsTabControl.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabControl.Controls.Add(this.WeekParseGroupBox);
            this.EnumsTabControl.Controls.Add(this.ValuesTextBox);
            this.EnumsTabControl.Controls.Add(this.ValueTextBoxLabel);
            this.EnumsTabControl.Controls.Add(this.ValueLabel);
            this.EnumsTabControl.Controls.Add(this.EnumsLabel);
            this.EnumsTabControl.Controls.Add(this.ValuesListBox);
            this.EnumsTabControl.Controls.Add(this.EnumerationsGroupBox);
            this.EnumsTabControl.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabControl.Name = "EnumsTabControl";
            this.EnumsTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabControl.Size = new System.Drawing.Size(688, 333);
            this.EnumsTabControl.TabIndex = 0;
            this.EnumsTabControl.Text = "Enums";
            this.EnumsTabControl.UseVisualStyleBackColor = true;
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
            // ClassesTabControl
            // 
            this.ClassesTabControl.Controls.Add(this.MovieGroupBox);
            this.ClassesTabControl.Controls.Add(this.ClassesGroupBox);
            this.ClassesTabControl.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabControl.Size = new System.Drawing.Size(688, 333);
            this.ClassesTabControl.TabIndex = 1;
            this.ClassesTabControl.Text = "Classes";
            this.ClassesTabControl.UseVisualStyleBackColor = true;
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
            this.MovieFindButton.Location = new System.Drawing.Point(162, 286);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(148, 24);
            this.MovieFindButton.TabIndex = 11;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(162, 195);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(148, 20);
            this.RatingTextBox.TabIndex = 10;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(159, 179);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 9;
            this.RatingLabel.Text = "Rating:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(162, 156);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(148, 20);
            this.DurationTextBox.TabIndex = 8;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(159, 140);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(50, 13);
            this.DurationLabel.TabIndex = 7;
            this.DurationLabel.Text = "Duration:";
            // 
            // ReleaseTextBox
            // 
            this.ReleaseTextBox.Location = new System.Drawing.Point(162, 117);
            this.ReleaseTextBox.Name = "ReleaseTextBox";
            this.ReleaseTextBox.Size = new System.Drawing.Size(148, 20);
            this.ReleaseTextBox.TabIndex = 6;
            this.ReleaseTextBox.TextChanged += new System.EventHandler(this.ReleaseTextBox_TextChanged);
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.Location = new System.Drawing.Point(159, 101);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.Size = new System.Drawing.Size(72, 13);
            this.ReleaseLabel.TabIndex = 5;
            this.ReleaseLabel.Text = "Release year:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.Location = new System.Drawing.Point(20, 19);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(123, 290);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(159, 62);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(162, 78);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(148, 20);
            this.GenreTextBox.TabIndex = 3;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(162, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(148, 20);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(159, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.IdLabel);
            this.ClassesGroupBox.Controls.Add(this.IdTextBox);
            this.ClassesGroupBox.Controls.Add(this.YLabel);
            this.ClassesGroupBox.Controls.Add(this.YTextBox);
            this.ClassesGroupBox.Controls.Add(this.XTextBox);
            this.ClassesGroupBox.Controls.Add(this.XLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesFindButton);
            this.ClassesGroupBox.Controls.Add(this.ColorTextBox);
            this.ClassesGroupBox.Controls.Add(this.WidthTextBox);
            this.ClassesGroupBox.Controls.Add(this.HeightTextBox);
            this.ClassesGroupBox.Controls.Add(this.ColorLabel);
            this.ClassesGroupBox.Controls.Add(this.WidthLabel);
            this.ClassesGroupBox.Controls.Add(this.HeightLabel);
            this.ClassesGroupBox.Controls.Add(this.RectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(0, 6);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(338, 327);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(157, 218);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 13;
            this.IdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(160, 234);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(148, 20);
            this.IdTextBox.TabIndex = 12;
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(157, 179);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 11;
            this.YLabel.Text = "Y:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(160, 195);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(148, 20);
            this.YTextBox.TabIndex = 10;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(160, 156);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(148, 20);
            this.XTextBox.TabIndex = 9;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(157, 140);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 8;
            this.XLabel.Text = "X:";
            // 
            // RectanglesFindButton
            // 
            this.RectanglesFindButton.Location = new System.Drawing.Point(160, 286);
            this.RectanglesFindButton.Name = "RectanglesFindButton";
            this.RectanglesFindButton.Size = new System.Drawing.Size(148, 24);
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
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(160, 39);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(148, 20);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
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
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(157, 23);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height:";
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
            // RectanglesTabControl
            // 
            this.RectanglesTabControl.Controls.Add(this.CanvasPanel);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleHeightTextBox);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleWidthTextBox);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleYTextBox);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleXTextBox);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleIdTextBox);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleHeightLabel);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleWidthLabel);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleYLabel);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleXLabel);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleIdLabel);
            this.RectanglesTabControl.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesTabControl.Controls.Add(this.RemoveRectangleButton);
            this.RectanglesTabControl.Controls.Add(this.AddRectangleButton);
            this.RectanglesTabControl.Controls.Add(this.RectanglesListBox2);
            this.RectanglesTabControl.Controls.Add(this.RectanglesLabel);
            this.RectanglesTabControl.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabControl.Name = "RectanglesTabControl";
            this.RectanglesTabControl.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabControl.Size = new System.Drawing.Size(688, 333);
            this.RectanglesTabControl.TabIndex = 2;
            this.RectanglesTabControl.Text = "Rectangles";
            this.RectanglesTabControl.UseVisualStyleBackColor = true;
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Location = new System.Drawing.Point(202, 6);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(478, 321);
            this.CanvasPanel.TabIndex = 15;
            // 
            // SelectedRectangleHeightTextBox
            // 
            this.SelectedRectangleHeightTextBox.Location = new System.Drawing.Point(46, 305);
            this.SelectedRectangleHeightTextBox.Name = "SelectedRectangleHeightTextBox";
            this.SelectedRectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleHeightTextBox.TabIndex = 14;
            this.SelectedRectangleHeightTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleHeightTextBox_TextChanged);
            // 
            // SelectedRectangleWidthTextBox
            // 
            this.SelectedRectangleWidthTextBox.Location = new System.Drawing.Point(46, 280);
            this.SelectedRectangleWidthTextBox.Name = "SelectedRectangleWidthTextBox";
            this.SelectedRectangleWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleWidthTextBox.TabIndex = 13;
            this.SelectedRectangleWidthTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleWidthTextBox_TextChanged);
            // 
            // SelectedRectangleYTextBox
            // 
            this.SelectedRectangleYTextBox.Location = new System.Drawing.Point(46, 254);
            this.SelectedRectangleYTextBox.Name = "SelectedRectangleYTextBox";
            this.SelectedRectangleYTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleYTextBox.TabIndex = 12;
            this.SelectedRectangleYTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleYTextBox_TextChanged);
            // 
            // SelectedRectangleXTextBox
            // 
            this.SelectedRectangleXTextBox.Location = new System.Drawing.Point(46, 228);
            this.SelectedRectangleXTextBox.Name = "SelectedRectangleXTextBox";
            this.SelectedRectangleXTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleXTextBox.TabIndex = 11;
            this.SelectedRectangleXTextBox.TextChanged += new System.EventHandler(this.SelectedRectangleXTextBox_TextChanged);
            // 
            // SelectedRectangleIdTextBox
            // 
            this.SelectedRectangleIdTextBox.Location = new System.Drawing.Point(46, 202);
            this.SelectedRectangleIdTextBox.Name = "SelectedRectangleIdTextBox";
            this.SelectedRectangleIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.SelectedRectangleIdTextBox.TabIndex = 10;
            // 
            // SelectedRectangleHeightLabel
            // 
            this.SelectedRectangleHeightLabel.AutoSize = true;
            this.SelectedRectangleHeightLabel.Location = new System.Drawing.Point(5, 308);
            this.SelectedRectangleHeightLabel.Name = "SelectedRectangleHeightLabel";
            this.SelectedRectangleHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.SelectedRectangleHeightLabel.TabIndex = 9;
            this.SelectedRectangleHeightLabel.Text = "Height:";
            // 
            // SelectedRectangleWidthLabel
            // 
            this.SelectedRectangleWidthLabel.AutoSize = true;
            this.SelectedRectangleWidthLabel.Location = new System.Drawing.Point(8, 283);
            this.SelectedRectangleWidthLabel.Name = "SelectedRectangleWidthLabel";
            this.SelectedRectangleWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.SelectedRectangleWidthLabel.TabIndex = 8;
            this.SelectedRectangleWidthLabel.Text = "Width:";
            // 
            // SelectedRectangleYLabel
            // 
            this.SelectedRectangleYLabel.AutoSize = true;
            this.SelectedRectangleYLabel.Location = new System.Drawing.Point(29, 257);
            this.SelectedRectangleYLabel.Name = "SelectedRectangleYLabel";
            this.SelectedRectangleYLabel.Size = new System.Drawing.Size(17, 13);
            this.SelectedRectangleYLabel.TabIndex = 7;
            this.SelectedRectangleYLabel.Text = "Y:";
            // 
            // SelectedRectangleXLabel
            // 
            this.SelectedRectangleXLabel.AutoSize = true;
            this.SelectedRectangleXLabel.Location = new System.Drawing.Point(29, 231);
            this.SelectedRectangleXLabel.Name = "SelectedRectangleXLabel";
            this.SelectedRectangleXLabel.Size = new System.Drawing.Size(17, 13);
            this.SelectedRectangleXLabel.TabIndex = 6;
            this.SelectedRectangleXLabel.Text = "X:";
            // 
            // SelectedRectangleIdLabel
            // 
            this.SelectedRectangleIdLabel.AutoSize = true;
            this.SelectedRectangleIdLabel.Location = new System.Drawing.Point(29, 205);
            this.SelectedRectangleIdLabel.Name = "SelectedRectangleIdLabel";
            this.SelectedRectangleIdLabel.Size = new System.Drawing.Size(19, 13);
            this.SelectedRectangleIdLabel.TabIndex = 5;
            this.SelectedRectangleIdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(6, 183);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(99, 13);
            this.SelectedRectangleLabel.TabIndex = 4;
            this.SelectedRectangleLabel.Text = "Selected rectangle:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(142, 147);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(54, 33);
            this.RemoveRectangleButton.TabIndex = 3;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveRectangleButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveRectangleButton_MouseLeave);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.Location = new System.Drawing.Point(18, 147);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(54, 33);
            this.AddRectangleButton.TabIndex = 2;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RectanglesListBox2
            // 
            this.RectanglesListBox2.FormattingEnabled = true;
            this.RectanglesListBox2.Location = new System.Drawing.Point(18, 25);
            this.RectanglesListBox2.Name = "RectanglesListBox2";
            this.RectanglesListBox2.Size = new System.Drawing.Size(178, 121);
            this.RectanglesListBox2.TabIndex = 1;
            this.RectanglesListBox2.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox2_SelectedIndexChanged);
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(6, 6);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 0;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 359);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.EnumsTabControl.ResumeLayout(false);
            this.EnumsTabControl.PerformLayout();
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekParseGroupBox.ResumeLayout(false);
            this.WeekParseGroupBox.PerformLayout();
            this.EnumerationsGroupBox.ResumeLayout(false);
            this.ClassesTabControl.ResumeLayout(false);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
            this.RectanglesTabControl.ResumeLayout(false);
            this.RectanglesTabControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabControl;
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
        private System.Windows.Forms.TabPage ClassesTabControl;
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
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TabPage RectanglesTabControl;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.ListBox RectanglesListBox2;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox SelectedRectangleHeightTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleWidthTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleYTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleXTextBox;
        private System.Windows.Forms.TextBox SelectedRectangleIdTextBox;
        private System.Windows.Forms.Label SelectedRectangleHeightLabel;
        private System.Windows.Forms.Label SelectedRectangleWidthLabel;
        private System.Windows.Forms.Label SelectedRectangleYLabel;
        private System.Windows.Forms.Label SelectedRectangleXLabel;
        private System.Windows.Forms.Label SelectedRectangleIdLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
    }
}

