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
            Array enumValue;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    enumValue = Enum.GetValues(typeof(Model.Color));
                    foreach (Model.Color color in enumValue)
                    {
                        ValuesListBox.Items.Add(color);
                    }
                    break;
                case "Education form":
                    enumValue = Enum.GetValues(typeof(EducationForm));
                    foreach (EducationForm form in enumValue)
                    {
                        ValuesListBox.Items.Add(form);
                    }
                    break;
                case "Genre":
                    enumValue = Enum.GetValues(typeof(Genre));
                    foreach (Genre genre in enumValue)
                    {
                        ValuesListBox.Items.Add(genre);
                    }
                    break;
                case "Seasons":
                    enumValue = Enum.GetValues(typeof(Seasons));
                    foreach (Seasons season in enumValue)
                    {
                        ValuesListBox.Items.Add(season);
                    }
                    break;
                case "Manufacture":
                    enumValue = Enum.GetValues(typeof(Manufacture));
                    foreach (Manufacture manufacture in enumValue)
                    {
                        ValuesListBox.Items.Add(manufacture);
                    }
                    break;
                case "Weekday":
                    enumValue = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday weekday in enumValue)
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
                ParserLabel.Text = $"\"This is the day of the week ({ParseTextBox.Text} = {(int)weekday})\"";
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
