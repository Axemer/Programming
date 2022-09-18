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

        private System.Drawing.Color _errorBackColor = System.Drawing.Color.LightPink;
        private System.Drawing.Color _defaultColor = System.Drawing.Color.White;

        public RectangleCollisionControl()
        {
            //Programming.View.Controls.RectangleControl sm = new Programming.View.Controls.RectangleControl();
            //_rectangles = sm._rectangles
            

            InitializeComponent();

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>(); // _rectangle.Count
            _rectanglesCollision = new List<Rectangle>();

            for (int i = 0; i < 5; i++) ////////// оно тут временно
            {
                Rectangle newRectangle = RectangleFactory.Randomize(
                    RactangleCanvasPanel.Width,
                    RactangleCanvasPanel.Height);

                _rectangles.Add(newRectangle);

                Panel rectanglePanel = new Panel();
                rectanglePanel.Width = 0;
                rectanglePanel.Height = 0;
                rectanglePanel.Location = new Point(0, 0);

                _rectanglesCollision.Add(newRectangle);

                RactangleListBox.Items.Add(
                    $"{_rectangles[i].ID}: (" +
                    $"X = {_rectangles[i].Center.X}; " +
                    $"Y = {_rectangles[i].Center.Y}; " +
                    "                                " +
                    $"W = {_rectangles[i].Length}; " +
                    $"H = {_rectangles[i].Width}) ");
            }

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
        /// Makes new panels //// may be redact this idk
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
            RactangleListBox.Items.Clear();
            IDTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            RactangleWidthTextBox.Clear();
            HeightTextBox.Clear();
            _currentRectangle = null;
        }

        /// <summary>
        /// ReAdds items in Ractangle list box
        /// </summary>
        private void RactangleListBoxUpdateItems()
        {
            foreach (var rectangle in _rectangles)
            {
                RactangleListBox.Items.Add(
                    $"{rectangle.ID}: (" +
                    $"X = {rectangle.Center.X}; " +
                    $"Y = {rectangle.Center.Y}; " +
                    "                           " +
                    $"W = {rectangle.Length}; " +
                    $"H = {rectangle.Width}) ");
            }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            //RectCollisionIDTextBox.Text = rectangle.ID.ToString();
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
                if (RactangleWidthTextBox.Focused == true)
                {
                    RactangleWidthTextBox.Text = rectangle.Length.ToString();
                    int newWidth = rectangle.Length;
                    _currentRectanglePanel.Size = new Size(newWidth, rectangle.Width);

                }


                // int newHeight = rectangle.Width;
                //_currentRectanglePanel.Location = new Point(newX, newY);

            }

        }

        private void RactangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RactangleListBox.SelectedIndex == -1)
                return;
            int rectangleIndex = RactangleListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleIndex];
            if (_rectanglePanels.Count >= rectangleIndex + 1)
                _currentRectanglePanel = _rectanglePanels[rectangleIndex];

            RactangleWidthTextBox.Text = _currentRectangle.Length.ToString();
            HeightTextBox.Text = _currentRectangle.Width.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IDTextBox.Text = _currentRectangle.ID.ToString();

            FindCollisions();
        }

        private void RactangleAddButton_Click(object sender, EventArgs e)
        {
            _rectangles.Add(RectangleFactory.Randomize(RactangleCanvasPanel.Width, RactangleCanvasPanel.Height));

            if (RactangleListBox.SelectedIndex >= 0)
            {
                Panel rectanglePanel = InitPanel();
                _rectanglePanels.Add(rectanglePanel);
                _rectanglesCollision.Add(_currentRectangle);

                // ничего не понимаю

                RactangleCanvasPanel.Controls.Add(rectanglePanel); // без нее не рисутся графика
            }
            ClearRectangleInfo();
            RactangleListBoxUpdateItems();
            FindCollisions();
        }

        private void RactangleReduceButton_Click(object sender, EventArgs e)
        {
            int rectangleIndexSecond = RactangleListBox.SelectedIndex;
            if (rectangleIndexSecond == -1) return;
            try
            {
                _rectanglesCollision.RemoveAt(rectangleIndexSecond);
                _rectangles.RemoveAt(rectangleIndexSecond);
                _rectanglePanels.RemoveAt(rectangleIndexSecond);
                RactangleCanvasPanel.Controls.RemoveAt(rectangleIndexSecond); /////////////////// nichego ne rabotae prichem ne yasno pochemu i eto ne sovsem izza -1
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            finally
            {
                //CanvasUpdate();
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
                Panel rectanglePanel = _rectanglePanels[RactangleListBox.SelectedIndex];

                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
                //CanvasUpdate();
            }

            catch (Exception)
            {
                XTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            XTextBox.BackColor = _defaultColor;
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Center.Y = int.Parse(YTextBox.Text);
                YTextBox.BackColor = _defaultColor;
                FindCollisions();
                //CanvasUpdate();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch (Exception)
            {
                YTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            YTextBox.BackColor = _defaultColor;
        }

        private void RactangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(RactangleWidthTextBox.Text);
                RactangleWidthTextBox.BackColor = _defaultColor;
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
                //CanvasUpdate();
            }

            catch (Exception)
            {
                RactangleWidthTextBox.BackColor = _errorBackColor;
            }
            RactangleWidthTextBox.BackColor = _defaultColor;
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = int.Parse(HeightTextBox.Text);
                HeightTextBox.BackColor = _defaultColor;
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
                //CanvasUpdate();

            }

            catch (Exception)
            {
                HeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            HeightTextBox.BackColor = _defaultColor;
        }

        /// <summary>
        /// Clearing Canvas panel and readds existing panels 
        /// </summary>
        private void CanvasUpdate()
        {
            RactangleCanvasPanel.Controls.Clear();
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                RactangleCanvasPanel.Controls.Add(_rectanglePanels[i]);
            }
        }

        ///////////////////// листбок становится шире благодаря этому //////////////////////////////

        /// <summary>
        /// Mesures items string lengh 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(RactangleListBox.Items[e.Index].ToString(), RactangleListBox.Font, RactangleListBox.Width).Height;
        }

        /// <summary>
        /// Draws items on next line 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (RactangleListBox.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(RactangleListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }



        ////used in main foe desighner in Ractavngle list Box 
        //this.RactangleListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
        //this.RactangleListBox.MeasureItem += lst_MeasureItem;
        //this.RactangleListBox.DrawItem += lst_DrawItem;
        ////
        //////////////// if double line listbox broke isert this in it's place 
        ///при любых изменениях в дизайнере все слктает м надо заново вставлять
    }
}
