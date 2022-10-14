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

namespace Programming.View.Controls
{
    public partial class RectangleCollisionControl : UserControl
    {
        private Panel _currentRectanglePanel;
        public List<Rectangle> _rectangles;
        private List<Panel> _rectanglePanels;
        private List<Rectangle> _rectanglesCollision;
        private Rectangle _currentRectangle;
        private int _currentIndex;

        private System.Drawing.Color _errorBackColor = System.Drawing.Color.LightPink;
        private System.Drawing.Color _defaultColor = System.Drawing.Color.White;

        public RectangleCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
            _rectanglesCollision = new List<Rectangle>();
        }

        /// <summary>
        /// Finds witch panels are colliding
        /// </summary>
        private void FindCollisions()
        {
            foreach (Panel panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (j != i && CollisionManager.IsCollision(_rectanglesCollision[i], _rectanglesCollision[j]))
                    {
                        _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        /// <summary>
        /// Makes new panels 
        /// </summary>
        /// <returns></returns>
        private Panel InitPanel()
        {
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = (int)_currentRectangle.Length;
            rectanglePanel.Height = (int)_currentRectangle.Width;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            return rectanglePanel;
        }

        /// <summary>
        /// Clears Ractangle list box and related text boxes
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectangleListBox.Items.Clear();
            IDTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            RectangleWidthTextBox.Clear();
            HeightTextBox.Clear();

            IDTextBox.BackColor = _defaultColor;
            XTextBox.BackColor = _defaultColor;
            YTextBox.BackColor = _defaultColor;
            RectangleWidthTextBox.BackColor = _defaultColor;
            HeightTextBox.BackColor = _defaultColor;

            _currentRectangle = null;
        }

        /// <summary>
        /// ReAdds items in Ractangle list box
        /// </summary>
        private void RactangleListBoxUpdateItems()
        {
            RectangleListBox.Items.Clear(); /// Крч с этим у нас проблема ибо 2рая линия тупо ломается если лист бокс мы чистим а без никак
                                            /// Здесь либо евент клика просчитывать либо что-то с последовательностью дествий делать или через фокус
            int i = 0;

            foreach (var rectangle in _rectangles)
            {
                i++;
                RectangleListBox.Items.Add(
                    $"{i}: (" +
                    $"X = {rectangle.Center.X}; " +
                    $"Y = {rectangle.Center.Y}; " +
                    "                           " +
                    $"W = {rectangle.Length}; " +
                    $"H = {rectangle.Width}) ");
            }
        }

        /// <summary>
        /// Обновляет данные о прямоугольнике
        /// </summary>
        /// <param name="rectangle"></param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (_currentRectanglePanel != null)
            {
                if (XTextBox.Focused == true)
                {
                    XTextBox.Text = rectangle.Center.X.ToString();
                    int newX = rectangle.Center.X;
                    _currentRectanglePanel.Location = new Point(newX, rectangle.Center.Y);

                }
                if (YTextBox.Focused == true)
                {
                    YTextBox.Text = rectangle.Center.Y.ToString();
                    int newY = rectangle.Center.Y;
                    _currentRectanglePanel.Location = new Point(rectangle.Center.X, newY);

                }

                if (HeightTextBox.Focused == true)
                {
                    HeightTextBox.Text = rectangle.Width.ToString();
                    int newHeight = rectangle.Width;
                    _currentRectanglePanel.Size = new Size(rectangle.Length, newHeight);
                }
                if (RectangleWidthTextBox.Focused == true)
                {
                    RectangleWidthTextBox.Text = rectangle.Length.ToString();
                    int newWidth = rectangle.Length;
                    _currentRectanglePanel.Size = new Size(newWidth, rectangle.Width);

                }
            }
        }

        private void RactangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectangleListBox.SelectedIndex == -1)
                return;
            int rectangleIndex = RectangleListBox.SelectedIndex;

            if (RectangleListBox.SelectedIndex >= 0)
                _currentIndex = RectangleListBox.SelectedIndex;

            _currentRectangle = _rectangles[rectangleIndex];

            if (_rectanglePanels.Count >= rectangleIndex + 1)
                _currentRectanglePanel = _rectanglePanels[rectangleIndex];

            RectangleWidthTextBox.Text = _currentRectangle.Length.ToString();
            HeightTextBox.Text =         _currentRectangle.Width.ToString();
            XTextBox.Text =              _currentRectangle.Center.X.ToString();
            YTextBox.Text =              _currentRectangle.Center.Y.ToString();
            IDTextBox.Text =             _currentRectangle.ID.ToString();

            FindCollisions();
        }

        private void RactangleAddButton_Click(object sender, EventArgs e)
        {
            Rectangle newRectangle = RectangleFactory.Randomize(RactangleCanvasPanel.Width, RactangleCanvasPanel.Height);
            _rectangles.Add(newRectangle);

            _currentRectangle = newRectangle;
            Panel rectanglePanel = InitPanel();
            _rectanglePanels.Add(rectanglePanel);
            _rectanglesCollision.Add(_currentRectangle);
            RactangleCanvasPanel.Controls.Add(rectanglePanel);

            ClearRectangleInfo();
            RactangleListBoxUpdateItems();
            FindCollisions();
        }

        private void RactangleReduceButton_Click(object sender, EventArgs e)
        {
            int rectangleIndexSecond = RectangleListBox.SelectedIndex;
            if (rectangleIndexSecond == -1) return;
            try
            {
                _rectanglesCollision.RemoveAt(rectangleIndexSecond);
                _rectangles.RemoveAt(rectangleIndexSecond);
                _rectanglePanels.RemoveAt(rectangleIndexSecond);
                RactangleCanvasPanel.Controls.RemoveAt(rectangleIndexSecond);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            finally
            {
                ClearRectangleInfo();
                RactangleListBoxUpdateItems();

                FindCollisions();
            }
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                _currentRectangle.Center.X = int.Parse(XTextBox.Text);
                XTextBox.BackColor = _defaultColor;
                Panel rectanglePanel = _rectanglePanels[RectangleListBox.SelectedIndex];

                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
                if (XTextBox.Focused)
                {
                    RactangleListBoxUpdateItems();
                    RectangleListBox.SelectedIndex = _currentIndex;
                }
            }

            catch (Exception)
            {
                XTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YTextBox.Text);
                YTextBox.BackColor = _defaultColor;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
                if (YTextBox.Focused)
                {
                    RactangleListBoxUpdateItems();
                    RectangleListBox.SelectedIndex = _currentIndex;
                }
            }

            catch (Exception)
            {
                YTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(RectangleWidthTextBox.Text);
                RectangleWidthTextBox.BackColor = _defaultColor;
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
                if (RectangleWidthTextBox.Focused)
                {
                    RactangleListBoxUpdateItems();
                    RectangleListBox.SelectedIndex = _currentIndex;
                }
            }

            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = _errorBackColor;
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = _defaultColor;
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
                if (HeightTextBox.Focused)
                {
                    RactangleListBoxUpdateItems();
                    RectangleListBox.SelectedIndex = _currentIndex;
                }
            }

            catch (Exception)
            {
                HeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        ///////////////////// листбок становится шире благодаря этому ListBox bec //////////////////////////////

        /// <summary>
        /// Mesures items string lengh 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="entry"></param>
        private void MeasureItem(object sender, MeasureItemEventArgs entry)
        {
            entry.ItemHeight = (int)entry.Graphics.MeasureString(RectangleListBox.Items[entry.Index].ToString(), 
                                                         RectangleListBox.Font, RectangleListBox.Width).Height;
        }

        /// <summary>
        /// Draws items on next line 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="entry"></param>
        private void DrawItem(object sender, DrawItemEventArgs entry)
        {
            if (RectangleListBox.Items.Count > 0)
            {
                entry.DrawBackground();
                entry.DrawFocusRectangle();
                entry.Graphics.DrawString(RectangleListBox.Items[entry.Index].ToString(), entry.Font, 
                                          new SolidBrush(entry.ForeColor), entry.Bounds);
            }
        }

        ////used in main foe designer in Rectangle list Box 
        //this.RectangleListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        //this.RectangleListBox.MeasureItem += MeasureItem;
        //this.RectangleListBox.DrawItem += DrawItem;
        ////
        //////////////// if double line listbox broke isert this in it's place 
    }
}
