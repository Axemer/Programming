using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.View.Controls;

namespace Programming.View.Controls
{
    public partial class RectangleControl : UserControl
    {
        private Rectangle _currentRectangle;
        public List<Rectangle> _rectangles;

        private System.Drawing.Color _errorBackColor = System.Drawing.Color.LightPink;
        private System.Drawing.Color _defaultColor = System.Drawing.Color.White;

        /// <summary>
        /// Finds Rectangle with highest width
        /// returns index of widest rectangle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles) //Rectangle[] rectangles
        {
            int indexMaxWidth = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
        }

        public RectangleControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            for (int i = 0; i<5; i++)
            {
                Rectangle newRectangle = RectangleFactory.Randomize(309,309);
                _rectangles.Add(newRectangle);
                RectanglesListBox.Items.Add(_rectangles[i].ToString());
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rectangleIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleIndex];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
            RactabgleCenterTextBox.Text = _currentRectangle.Center.X.ToString() + ", " + _currentRectangle.Center.Y.ToString();
            RactangleIDTextBox.Text = _currentRectangle.ID.ToString();
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(RectangleLengthTextBox.Text);
                RectangleLengthTextBox.BackColor = _defaultColor;
            }

            catch (Exception)
            {
                RectangleLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = _defaultColor;
            }

            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = _errorBackColor;
            }
        }

        private void RectangleColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectangleColorTextBox.Text;

        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);

        }
    }
}
