
namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.MovieGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(336, 327);
            this.MovieGroupBox.TabIndex = 2;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(337, 327);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MovieFindButton;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox ReleaseTextBox;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.GroupBox MovieGroupBox;
    }
}
