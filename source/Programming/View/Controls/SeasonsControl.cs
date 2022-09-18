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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            var seasons = Enum.GetValues(typeof(Seasons));
            foreach (var value in seasons)
            {
                SeasonComboBox.Items.Add(value);
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
