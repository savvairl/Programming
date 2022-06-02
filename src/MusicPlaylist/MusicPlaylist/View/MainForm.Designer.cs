
namespace MusicPlaylist.View
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
            this.MusicListBox = new System.Windows.Forms.ListBox();
            this.SelectedSongGroupBox = new System.Windows.Forms.GroupBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.ArtistTextBox = new System.Windows.Forms.TextBox();
            this.SongNameTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.SongNameLabel = new System.Windows.Forms.Label();
            this.DeleteSongButton = new System.Windows.Forms.Button();
            this.AddSongButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SelectedSongGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicListBox
            // 
            this.MusicListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MusicListBox.FormattingEnabled = true;
            this.MusicListBox.Location = new System.Drawing.Point(12, 12);
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(209, 394);
            this.MusicListBox.TabIndex = 0;
            this.MusicListBox.SelectedIndexChanged += new System.EventHandler(this.MusicListBox_SelectedIndexChanged);
            // 
            // SelectedSongGroupBox
            // 
            this.SelectedSongGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.DurationTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.ArtistTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.SongNameTextBox);
            this.SelectedSongGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedSongGroupBox.Controls.Add(this.DurationLabel);
            this.SelectedSongGroupBox.Controls.Add(this.ArtistLabel);
            this.SelectedSongGroupBox.Controls.Add(this.SongNameLabel);
            this.SelectedSongGroupBox.Location = new System.Drawing.Point(227, 12);
            this.SelectedSongGroupBox.Name = "SelectedSongGroupBox";
            this.SelectedSongGroupBox.Size = new System.Drawing.Size(373, 132);
            this.SelectedSongGroupBox.TabIndex = 1;
            this.SelectedSongGroupBox.TabStop = false;
            this.SelectedSongGroupBox.Text = "Selected song";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(128, 97);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(232, 20);
            this.GenreTextBox.TabIndex = 7;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(128, 71);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.ReadOnly = true;
            this.DurationTextBox.Size = new System.Drawing.Size(232, 20);
            this.DurationTextBox.TabIndex = 6;
            // 
            // ArtistTextBox
            // 
            this.ArtistTextBox.Location = new System.Drawing.Point(128, 45);
            this.ArtistTextBox.Name = "ArtistTextBox";
            this.ArtistTextBox.ReadOnly = true;
            this.ArtistTextBox.Size = new System.Drawing.Size(232, 20);
            this.ArtistTextBox.TabIndex = 5;
            // 
            // SongNameTextBox
            // 
            this.SongNameTextBox.Location = new System.Drawing.Point(128, 19);
            this.SongNameTextBox.Name = "SongNameTextBox";
            this.SongNameTextBox.ReadOnly = true;
            this.SongNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.SongNameTextBox.TabIndex = 4;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(83, 100);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(23, 74);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(99, 13);
            this.DurationLabel.TabIndex = 2;
            this.DurationLabel.Text = "Duration (seconds):";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Location = new System.Drawing.Point(89, 48);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Size = new System.Drawing.Size(33, 13);
            this.ArtistLabel.TabIndex = 1;
            this.ArtistLabel.Text = "Artist:";
            // 
            // SongNameLabel
            // 
            this.SongNameLabel.AutoSize = true;
            this.SongNameLabel.Location = new System.Drawing.Point(58, 22);
            this.SongNameLabel.Name = "SongNameLabel";
            this.SongNameLabel.Size = new System.Drawing.Size(64, 13);
            this.SongNameLabel.TabIndex = 0;
            this.SongNameLabel.Text = "Song name:";
            // 
            // DeleteSongButton
            // 
            this.DeleteSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSongButton.FlatAppearance.BorderSize = 0;
            this.DeleteSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSongButton.Image = global::MusicPlaylist.Properties.Resources.delete_24x24_uncolor;
            this.DeleteSongButton.Location = new System.Drawing.Point(74, 412);
            this.DeleteSongButton.Name = "DeleteSongButton";
            this.DeleteSongButton.Size = new System.Drawing.Size(25, 25);
            this.DeleteSongButton.TabIndex = 3;
            this.DeleteSongButton.UseVisualStyleBackColor = true;
            this.DeleteSongButton.Click += new System.EventHandler(this.DeleteSongButton_Click);
            this.DeleteSongButton.MouseEnter += new System.EventHandler(this.DeleteSongButton_MouseEnter);
            this.DeleteSongButton.MouseLeave += new System.EventHandler(this.DeleteSongButton_MouseLeave);
            // 
            // AddSongButton
            // 
            this.AddSongButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddSongButton.FlatAppearance.BorderSize = 0;
            this.AddSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSongButton.Image = global::MusicPlaylist.Properties.Resources.add_24x24_uncolor;
            this.AddSongButton.Location = new System.Drawing.Point(12, 412);
            this.AddSongButton.Name = "AddSongButton";
            this.AddSongButton.Size = new System.Drawing.Size(25, 25);
            this.AddSongButton.TabIndex = 2;
            this.AddSongButton.UseVisualStyleBackColor = true;
            this.AddSongButton.Click += new System.EventHandler(this.AddSongButton_Click);
            this.AddSongButton.MouseEnter += new System.EventHandler(this.AddSongButton_MouseEnter);
            this.AddSongButton.MouseLeave += new System.EventHandler(this.AddSongButton_MouseLeave);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = global::MusicPlaylist.Properties.Resources.edit_24x24_uncolor;
            this.EditButton.Location = new System.Drawing.Point(43, 412);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(25, 25);
            this.EditButton.TabIndex = 4;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            this.EditButton.MouseEnter += new System.EventHandler(this.EditButton_MouseEnter);
            this.EditButton.MouseLeave += new System.EventHandler(this.EditButton_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 447);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteSongButton);
            this.Controls.Add(this.AddSongButton);
            this.Controls.Add(this.SelectedSongGroupBox);
            this.Controls.Add(this.MusicListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MusicPlaylist";
            this.SelectedSongGroupBox.ResumeLayout(false);
            this.SelectedSongGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MusicListBox;
        private System.Windows.Forms.GroupBox SelectedSongGroupBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox ArtistTextBox;
        private System.Windows.Forms.TextBox SongNameTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Label SongNameLabel;
        private System.Windows.Forms.Button AddSongButton;
        private System.Windows.Forms.Button DeleteSongButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox GenreTextBox;
    }
}

