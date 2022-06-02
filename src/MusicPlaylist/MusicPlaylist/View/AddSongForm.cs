using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicPlaylist.Model;

namespace MusicPlaylist.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению окна добавления песни.
    /// </summary>
    public partial class AddSongForm : Form
    {
        /// <summary>
        /// Песня.
        /// </summary>
        private Song _song;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddSongForm"/>.
        /// </summary>
        public AddSongForm()
        {
            InitializeComponent();

            _song = new Song();
            SongNameTextBox.Text = "Song";
            ArtistTextBox.Text = "Artist";
            DurationTextBox.Text = "123";
            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
            {
                GenreComboBox.Items.Add(value);
            }

            GenreComboBox.SelectedIndex = 0;
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string songNameString = SongNameTextBox.Text;
                _song.SongName = songNameString;
            }
            catch
            {
                SongNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            SongNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ArtistTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string artistString = ArtistTextBox.Text;
                _song.Artist = artistString;
            }
            catch
            {
                ArtistTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            ArtistTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string durationString = DurationTextBox.Text;
                int durationValue = int.Parse(durationString);
                _song.Duration = durationValue;
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            DurationTextBox.BackColor = AppColors.CorrectColor;
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _song.Genre = (Genre)GenreComboBox.SelectedItem;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CorrectValuesManager.IsCorrect(SongNameTextBox, ArtistTextBox, DurationTextBox))
            {
                SongData.Song = _song;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Введены неверные значения.", "Error");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
