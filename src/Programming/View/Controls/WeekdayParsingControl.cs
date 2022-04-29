using System;
using Programming.Model;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(ParsingValueTextbox.Text, out weekday))
            {
                WeekParseLabel.Text = $"Это день недели ({weekday} = {(int)weekday}).";
            }
            else
            {
                WeekParseLabel.Text = "Нет такого дня недели.";
            }
        }
    }
}
