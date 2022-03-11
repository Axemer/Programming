using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Model
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            
            var values = Enum.GetValues(typeof(Seasons));
            foreach (var value in values)
            {
                Season_comboBox.Items.Add(value);
            }


        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
            
        {
            Array EnumValue;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    EnumValue = Enum.GetValues(typeof(Color));
                    foreach (Color value in EnumValue)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Education type":
                    EnumValue = Enum.GetValues(typeof(Education_type));
                    foreach (Education_type value in EnumValue)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Genre":
                    EnumValue = Enum.GetValues(typeof(Genre));
                    foreach (Genre value in EnumValue)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Seasons":
                    EnumValue = Enum.GetValues(typeof(Seasons));
                    foreach (Seasons value in EnumValue)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Manufacture":
                    EnumValue = Enum.GetValues(typeof(Manufacture));
                    foreach (Manufacture value in EnumValue)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
                case "Weekday":
                    EnumValue = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday value in EnumValue)
                    {
                        ValuesListBox.Items.Add(value);
                    }
                    break;
            }

        }

        
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void Parse_button_Click(object sender, EventArgs e)
        {
            Weekday value;
            if (Enum.TryParse(Parse_textBox.Text, out value))
            {
                ParserLabel.Text = $"\"This is the day of the week ({Parse_textBox.Text} = {(int)value})\"";
            }
            else
            {
                ParserLabel.Text = "\"This day doesnt exist\"";
            }
        }

        private void Season_button_Click(object sender, EventArgs e)
        {
            if (Season_comboBox.SelectedItem == null) { return; }
            switch (Season_comboBox.SelectedItem)
            {
                case Seasons.Spring:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#90ee90");
                    break;
                case Seasons.Summer:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#F0FFFF");
                    break;
                case Seasons.Autumn:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#FF8C00");
                    break;
                case Seasons.Winter:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#FFFAFA");
                    break;
            }
        }
    }
}
