using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;



namespace Programming.View.Controls
{
    public partial class MovieControl : UserControl
    {

        private Movie[] _movies;
        private string[] _titlesMovies = {
            "Forsaken By The End",
            "Wrong About The East",
            "Guarding My Future",
            "Growing In The Mountains",
            "Learning From The Depths"};
        private Movie _currentMovie;
        private string[] _genres;

        public System.Drawing.Color _errorBackColor = System.Drawing.Color.LightPink;
        public System.Drawing.Color _currentBackColor = System.Drawing.Color.White;

        Random random = new Random();


        public MovieControl()
        {
            InitializeComponent();

            _genres = Enum.GetNames(typeof(Genre));

            _movies = new Movie[5];

            for (int i = 0; i < _movies.Length; i++)
            {
                _movies[i] = new Movie(_titlesMovies[i], random.Next(60, 120), random.Next(1900, DateTime.Now.Year),
                                       _genres[random.Next(0, _genres.Length)], Math.Round(random.NextDouble() * 10, 1));

                MoviesListBox.Items.Add(_movies[i].ToString());
            }
        }

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

        private void MovieYearTextBox_TextChanged(object sender, EventArgs e)
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

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
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

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
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

        private void MovieDurationTextBox_TextChanged(object sender, EventArgs e)
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

        private void MovieFindButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);

        }
    }
}
