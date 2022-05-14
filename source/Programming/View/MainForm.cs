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
using Programming.Model.Classes;
using Rectangle = Programming.Model.Classes.Rectangle; // необходимо для исключения конфликта с sys.Drawing
using Color = Programming.Model.Color;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        public Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private string[] _colors;
        private Movie[] _movies;
        private string[] _titlesMovies = { 
            "Forsaken By The End", 
            "Wrong About The East", 
            "Guarding My Future", 
            "Growing In The Mountains", 
            "Learning From The Depths"};
        private Movie _currentMovie;
        private string[] _genres;
        private System.Drawing.Color _errorBackColor = System.Drawing.Color.LightPink;
        private System.Drawing.Color _currentBackColor = System.Drawing.Color.White;
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();

            var seasons = Enum.GetValues(typeof(Seasons));
            foreach (var value in seasons)
            {
                SeasonComboBox.Items.Add(value);
            }

            _colors = Enum.GetNames(typeof(Color));
            _genres = Enum.GetNames(typeof(Genre));

            _rectangles = new Rectangle[5];

            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = new Rectangle(random.Next(0, 100), random.Next(0, 100),
                                                  _colors[random.Next(_colors.Length)]);

                RectanglesListBox.Items.Add(_rectangles[i].ToString());

            }
            // Movies
            _movies = new Movie[5];

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(_titlesMovies[i], random.Next(60, 120), random.Next(1900, DateTime.Now.Year),
                                       _genres[random.Next(0, _genres.Length)], Math.Round(random.NextDouble() * 10, 1));

                MoviesListBox.Items.Add(_movies[i].ToString());
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

        // Classes /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Rectangles
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rectangleIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[rectangleIndex];
            RectangleLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectangleWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectangleColorTextBox.Text = _currentRectangle.Color;
        }

        private void RectangleLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = int.Parse(RectangleLengthTextBox.Text);
                RectangleLengthTextBox.BackColor = _currentBackColor;
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
                RectangleWidthTextBox.BackColor = _currentBackColor;
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

        /// <summary>
        /// Finds Rectangle with highest width
        /// returns index of widest rectangle 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMaxWidth = 0;
            double maxWidth = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    indexMaxWidth = i;
                }
            }
            return indexMaxWidth;
        }

        private void RectangleFindButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);

        }

        //movies
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[indexMovie];
            MovieTitleTextBox.Text = _currentMovie.Title;
            MovieDurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }
        /// <summary>
        /// Finds movie with max rating
        /// returns index of movie
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        /// 

       

       

        

        


        private int FindMovieWithMaxRating(Movie[] movie)
        {
            int indexMaxRating = 0;
            double maxRating = 0;
            for (int i = 0; i < movie.Length; i++)
            {
                if (movie[i].Rating > maxRating)
                {
                    maxRating = movie[i].Rating;
                    indexMaxRating = i;
                }
            }
            return indexMaxRating;
        }

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void MovieTitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Title = MovieTitleTextBox.Text;
                MovieTitleTextBox.BackColor = _currentBackColor;
            }

            catch (Exception)
            {
                MovieTitleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieYearTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(MovieYearTextBox.Text);
                MovieYearTextBox.BackColor = _currentBackColor;
            }

            catch (Exception)
            {
                MovieYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieRatingTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(MovieRatingTextBox.Text);
                MovieRatingTextBox.BackColor = _currentBackColor;
            }

            catch (Exception)
            {
                MovieRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieGenreTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = MovieGenreTextBox.Text;
                MovieGenreTextBox.BackColor = _currentBackColor;
            }

            catch (Exception)
            {
                MovieGenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void MovieDurationTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationMinutes = int.Parse(MovieDurationTextBox.Text);
                MovieDurationTextBox.BackColor = _currentBackColor;
            }

            catch (Exception)
            {
                MovieDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
