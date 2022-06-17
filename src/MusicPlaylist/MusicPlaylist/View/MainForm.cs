using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MusicPlaylist.Model;
using System.IO;
using Newtonsoft.Json;
using MusicPlaylist.Properties;

namespace MusicPlaylist.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь до директории AppData.
        /// </summary>
        private string AppDataPath = Application.UserAppDataPath;

        /// <summary>
        /// Окно добавления песни.
        /// </summary>
        private AddSongForm _addSongForm;

        /// <summary>
        /// Окно редактирования песни.
        /// </summary>
        private EditSongForm _songForm;

        /// <summary>
        /// Выбранная песня.
        /// </summary>
        private Song _currentSong;

        /// <summary>
        /// Коллекция песен.
        /// </summary>
        private List<Song> _songs;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _songs = Serializer.Deserialize(AppDataPath);
            UpdateListBox(-1);
        }

        /// <summary>
        /// Очищает все поля.
        /// </summary>
        private void ClearAllFields()
        {
            SongNameTextBox.Clear();
            ArtistTextBox.Clear();
            GenreTextBox.Clear();
            DurationTextBox.Clear();
        }

        /// <summary>
        /// Сортирует список песен.
        /// </summary>
        private void SortList()
        {
            var orderedMusicList = from song in _songs
                                   orderby song.Artist, song.SongName
                                   select song;
            _songs = orderedMusicList.ToList();
        }

        /// <summary>
        /// Ищет индекс элемента по уникальному идентификатору.
        /// </summary>
        /// <returns>Возвращает индекс найденного элемента.</returns>
        private int FindItemIndexById()
        {
            SortList();
            int index = _songs.IndexOf(_currentSong);
            return index;
        }

        /// <summary>
        /// Обновляет данные в списке ListBox.
        /// </summary>
        /// <param name="selectedIndex">Индекс выбранного элемента.</param>
        private void UpdateListBox(int selectedIndex)
        {
            MusicListBox.Items.Clear();

            SortList();

            foreach (Song song in _songs)
            {
                MusicListBox.Items.Add($"{song.Artist} - {song.SongName}");
            }

            MusicListBox.SelectedIndex = selectedIndex;
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            _addSongForm = new AddSongForm();

            if (_addSongForm.ShowDialog() != DialogResult.OK) return;

            _songs.Add(SongData.Song);
            Serializer.Serialize(AppDataPath, _songs);
            UpdateListBox(0);
        }

        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            int index = MusicListBox.SelectedIndex;

            if (index == -1) return;

            _songs.RemoveAt(index);
            UpdateListBox(-1);
            ClearAllFields();
            Serializer.Serialize(AppDataPath, _songs);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MusicListBox.SelectedIndex == -1)
            {
                return;
            }

            SongData.Song = _currentSong;

            _songForm = new EditSongForm();

            if (_songForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _currentSong = SongData.Song;

            int index = FindItemIndexById();
            UpdateListBox(index);
            Serializer.Serialize(AppDataPath, _songs);
        }

        private void MusicListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = MusicListBox.SelectedIndex;

            if (index == -1) return;

            _currentSong = _songs[index];
            SongNameTextBox.Text = _currentSong.SongName;
            ArtistTextBox.Text = _currentSong.Artist;
            DurationTextBox.Text = _currentSong.Duration.ToString();
            GenreTextBox.Text = _currentSong.Genre.ToString();
        }


        private void AddSongButton_MouseEnter(object sender, EventArgs e)
        {
            AddSongButton.Image = Resources.add_24x24_color;
        }

        private void AddSongButton_MouseLeave(object sender, EventArgs e)
        {
            AddSongButton.Image = Resources.add_24x24_uncolor;
        }

        private void DeleteSongButton_MouseEnter(object sender, EventArgs e)
        {
            DeleteSongButton.Image = Resources.delete_24x24_color;
        }

        private void DeleteSongButton_MouseLeave(object sender, EventArgs e)
        {
            DeleteSongButton.Image = Resources.delete_24x24_uncolor;
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Resources.edit_24x24_color;
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Resources.edit_24x24_uncolor;
        }
    }
}
