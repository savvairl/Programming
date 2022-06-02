using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MusicPlaylist.Model;
using MusicPlaylist.Properties;

namespace MusicPlaylist.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению окна изменения данных песни.
    /// </summary>
    public partial class EditSongForm : Form
    {
        /// <summary>
        /// Песня.
        /// </summary>
        private Song _song;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="EditSongForm"/>.
        /// </summary>
        public EditSongForm()
        {
            InitializeComponent();

            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
            {
                GenreComboBox.Items.Add(value);
            }

            _song = SongData.Song;

            SongNameTextBox.Text = _song.SongName;
            ArtistTextBox.Text = _song.Artist;
            DurationTextBox.Text = _song.Duration.ToString();
            GenreComboBox.SelectedItem = _song.Genre;
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
    }
}
