using System;
using Programming.Model;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class EnumerationControl : UserControl
    {
        public EnumerationControl()
        {
            InitializeComponent();
            Array allEnums = Enum.GetValues(typeof(Enums));
            foreach (Enums value in allEnums)
            {
                EnumsListBox.Items.Add(value);
            }
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enums;
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Color:
                    enums = Enum.GetValues(typeof(Color));
                    break;
                case Enums.Weekday:
                    enums = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Season:
                    enums = Enum.GetValues(typeof(Season));
                    break;
                case Enums.Manufacture:
                    enums = Enum.GetValues(typeof(Manufacture));
                    break;
                case Enums.Genre:
                    enums = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    enums = Enum.GetValues(typeof(EducationForm));
                    break;
                default:
                    throw new NotImplementedException();
            }
            foreach (var value in enums)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(ValuesListBox.SelectedItem == null))
            {
                ValuesTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
            }
        }

        private void EnumerationControl_Load(object sender, EventArgs e)
        {

        }
    }
}
