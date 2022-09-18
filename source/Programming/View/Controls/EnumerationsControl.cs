using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Color = Programming.Model.Enums.Color;


namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array enumValue;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                    enumValue = Enum.GetValues(typeof(Color));
                    foreach (Color color in enumValue)
                    {
                        ValuesListBox.Items.Add(color);
                    }
                    break;
                case "Education type":
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
    }
}
