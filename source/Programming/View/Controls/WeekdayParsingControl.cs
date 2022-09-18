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
            if (Enum.TryParse(ParseTextBox.Text, out weekday))
            {
                ParserLabel.Text = $"\"This is the day of the week ({ParseTextBox.Text} = {(int)weekday})\"";
            }

            else
            {
                ParserLabel.Text = "\"This day doesnt exist\"";
            }
        }

       
    }
}
