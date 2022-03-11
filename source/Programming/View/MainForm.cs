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

namespace Programming.View ////// тут кароче должно быть viev но с ним нихуя не работает как это сделать в душе не ебу
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var seasons = Enum.GetValues(typeof(Seasons));
            foreach (var value in seasons)
            {
                SeasonComboBox.Items.Add(value);
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array EnumValue;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    EnumValue = Enum.GetValues(typeof(Model.Color));
                    foreach (Model.Color color in EnumValue)
                    {
                        ValuesListBox.Items.Add(color);
                    }
                    break;
                case "Education form":
                    EnumValue = Enum.GetValues(typeof(EducationForm));
                    foreach (EducationForm form in EnumValue)
                    {
                        ValuesListBox.Items.Add(form);
                    }
                    break;
                case "Genre":
                    EnumValue = Enum.GetValues(typeof(Genre));
                    foreach (Genre genre in EnumValue)
                    {
                        ValuesListBox.Items.Add(genre);
                    }
                    break;
                case "Seasons":
                    EnumValue = Enum.GetValues(typeof(Seasons));
                    foreach (Seasons season in EnumValue)
                    {
                        ValuesListBox.Items.Add(season);
                    }
                    break;
                case "Manufacture":
                    EnumValue = Enum.GetValues(typeof(Manufacture));
                    foreach (Manufacture manufacture in EnumValue)
                    {
                        ValuesListBox.Items.Add(manufacture);
                    }
                    break;
                case "Weekday":
                    EnumValue = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday weekday in EnumValue)
                    {
                        ValuesListBox.Items.Add(weekday);
                    }
                    break;
            }

        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }
        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(ParseTextBox.Text, out weekday))
            {
                ParserLabel.Text = $"\"This is the day of the week ({ParseTextBox.Text} = {(int)weekday + 1})\"";
            }
            else
            {
                ParserLabel.Text = "\"This day doesnt exist\"";
            }
        }
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null) { return; }
            switch (SeasonComboBox.SelectedItem)
            {
                case Seasons.Spring:
                    SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#90ee90");
                    break;
                case Seasons.Summer:
                    SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#F0FFFF");
                    break;
                case Seasons.Autumn:
                    SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#FF8C00");
                    break;
                case Seasons.Winter:
                    SeasonGroupBox.BackColor = ColorTranslator.FromHtml("#FFFAFA");
                    break;
            }
        }
    }
}
