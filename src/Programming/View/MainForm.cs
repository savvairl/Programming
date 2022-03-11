using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Color = Programming.Model.Color;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
            SeasonChooseCombobox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Color:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Color));
                    break;
                case Enums.EducationForm:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufacture:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacture));
                    break;
                case Enums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday wday;
            if (Enum.TryParse(ParsingValueTextbox.Text, out wday))
            {
                WeekParseLabel.Text = $"Это день недели ({wday.ToString()} = {(int)wday}).";
            }
            else
            {
                WeekParseLabel.Text = "Нет такого дня недели.";
            }
        }

        private void SeasonChooseButton_Click(object sender, EventArgs e)
        {
            switch ((Season)SeasonChooseCombobox.SelectedItem)
            {
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    BackColor = System.Drawing.Color.Green;
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    BackColor = System.Drawing.Color.Orange;
                    break;
                default:
                    MessageBox.Show("Сезон не выбран", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
