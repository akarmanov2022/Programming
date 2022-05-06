using System;
using System.Globalization;
using System.Windows.Forms;
using Programming.Model;
using Programming.Service;
using static Programming.Service.Validator;

namespace Programming.View.GroupBoxes
{
    public partial class MovieGroupBoxControl : UserControl
    {
        private Movie[] _movies;

        private Movie _currentMovie;


        public MovieGroupBoxControl()
        {
            _movies = MovieFactory.GenerateRandomMovies(5);
            InitializeComponent();
            ListBoxClassesFilms.Items.AddRange(_movies);
        }

        private void ListBoxClassesFilms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var films = _movies;
            var index = ListBoxClassesFilms.SelectedIndex;
            _currentMovie = films[index];

            TextBoxClassesFilmsDuration.Text = _currentMovie.Duration.ToString();
            TextBoxClassesFilmsYear.Text = _currentMovie.Year.ToString();
            TextBoxClassesFilmsName.Text = _currentMovie.Name;
            TextBoxClassesFilmsGenre.Text = _currentMovie.Genre;
            TextBoxClassesFilmsRating.Text = _currentMovie.Rating.ToString(CultureInfo.InvariantCulture);
        }

        private void ButtonClassesFilmsFind_Click(object sender, EventArgs e)
        {
            var movies = _movies;
            var index = MovieFactory.FindMovieWithMaxRating(movies);
            ListBoxClassesFilms.SelectedIndex = index;
        }

        private void TextBoxClassesFilmsDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesFilmsDuration.BackColor = BackColorSuccess;
                var text = TextBoxClassesFilmsDuration.Text;
                _currentMovie.Duration = int.Parse(text);
            }
            catch (Exception)
            {
                TextBoxClassesFilmsDuration.BackColor = BackColorException;
            }
        }

        private void TextBoxClassesFilmsYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesFilmsYear.BackColor = BackColorSuccess;
                var text = TextBoxClassesFilmsYear.Text;
                _currentMovie.Year = int.Parse(text);
            }
            catch (Exception)
            {
                TextBoxClassesFilmsYear.BackColor = BackColorException;
            }
        }

        private void TextBoxClassesFilmsRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesFilmsRating.BackColor = BackColorSuccess;
                var text = TextBoxClassesFilmsRating.Text;
                _currentMovie.Rating = int.Parse(text);
            }
            catch (Exception)
            {
                TextBoxClassesFilmsRating.BackColor = BackColorException;
            }
        }

        private void TextBoxClassesFilmsName_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = TextBoxClassesFilmsName.Text;
        }

        private void TextBoxClassesFilmsGenre_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = TextBoxClassesFilmsGenre.Text;
        }

        private void TextBox_KeyPressCancel(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}