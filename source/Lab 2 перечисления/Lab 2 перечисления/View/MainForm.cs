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
        }

        private void MainForm_Load(object sender, EventArgs args)
        {

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
                case "Smartphone Manufacture":
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

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void ValuesListBox_Click(object sender, EventArgs e)
        {
            IntValueBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        private void EnumsListBox_Click(object sender, EventArgs e)
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
                case Seasons.spring:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#90ee90");
                    //Season_groupBox.BackColor = System.Drawing.Color
                    break;
                case Seasons.summer:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#F0FFFF");
                    break;
                case Seasons.autum:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#FF8C00");
                    break;
                case Seasons.winter:
                    Season_groupBox.BackColor = ColorTranslator.FromHtml("#FFFAFA");
                    break;
            }
        }
    }
}
