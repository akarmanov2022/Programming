using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enum;
using Programming.Service;
using Color = Programming.Model.Enum.EnumColor;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private static readonly System.Drawing.Color BackColorSuccess = System.Drawing.Color.White;

        private static readonly System.Drawing.Color BackColorError = System.Drawing.Color.LightPink;

        private List<Type> _types;

        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _rectangles = RectangleService.GenerateRandomRectangles(5);
            _movies = MovieService.GenerateRandomMovies(5);

            _types = new List<Type>()
            {
                typeof(Color),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(Season),
                typeof(TrainingType),
                typeof(Weekday)
            };

            ListBoxClassesFilms.Items.AddRange(_movies);
            ListBoxClassesRectangles.Items.AddRange(_rectangles.ToArray());
            ListBoxEnums.Items.AddRange(_types.ToArray());
            ListBoxEnums.SetSelected(0, true);

            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values) ComboBoxSeasons.Items.Add(value);
        }

        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxValues.Items.Clear();
            var item = ListBoxEnums.SelectedItem;
            var type = (Type) item;
            var values = type.GetEnumValues();
            foreach (var value in values) ListBoxValues.Items.Add(value);
        }

        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ListBoxValues.SelectedItem;
            TextBoxIntValue.Text = ((int) item).ToString();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var text = TextBoxValueParse.Text;
            var types = _types;

            foreach (var enumValue in from type in types
                     where Enum.IsDefined(type, text)
                     select Enum.Parse(type, text, true))
            {
                LabelTextParse.Text = enumValue + @" - " + (int) enumValue;
                break;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var item = ComboBoxSeasons.SelectedItem;
            switch (item)
            {
                case Season.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Season.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Summer:
                    BackColor = BackColorSuccess;
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Season.Winter:
                    BackColor = BackColorSuccess;
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ButtonClassesRectangleFind_Click(object sender, EventArgs e)
        {
            var rectangles = _rectangles ?? throw new ArgumentNullException(nameof(_rectangles));
            var index = RectangleService.FindRectangleWithMaxWidth(rectangles);

            ListBoxClassesRectangles.SelectedIndex = index;
        }

        private void ListBoxClassesRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rectangles = _rectangles;
            var index = ListBoxClassesRectangles.SelectedIndex;
            _currentRectangle = rectangles[index];

            TextBoxClassesRectangleColor.Text = _currentRectangle.Color;
            TextBoxClassesRectangleLength.Text = _currentRectangle.Length.ToString(CultureInfo.InvariantCulture);
            TextBoxClassesRectangleWidth.Text = _currentRectangle.Width.ToString(CultureInfo.InvariantCulture);
            TextBoxClassesRectangleCenter.Text = _currentRectangle.Center.ToString();
            TextBoxClassesRectangleId.Text = _currentRectangle.Id.ToString();
        }

        private void TextBoxClassesRectangleLength_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleLength.BackColor = BackColorSuccess;
                var text = TextBoxClassesRectangleLength.Text;
                _currentRectangle.Length = double.Parse(text.Replace('.', ','));
            }
            catch (Exception)
            {
                TextBoxClassesRectangleLength.BackColor = BackColorError;
            }
        }

        private void TextBoxClassesRectangleWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleWidth.BackColor = BackColorSuccess;
                var text = TextBoxClassesRectangleWidth.Text;
                _currentRectangle.Width = double.Parse(text.Replace('.', ','));
            }
            catch (Exception)
            {
                TextBoxClassesRectangleWidth.BackColor = BackColorError;
            }
        }

        private void TextBoxClassesRectangleColor_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = TextBoxClassesRectangleColor.Text;
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
            var index = MovieService.FindMovieWithMaxRating(movies);
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
                TextBoxClassesFilmsDuration.BackColor = BackColorError;
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
                TextBoxClassesFilmsYear.BackColor = BackColorError;
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
                TextBoxClassesFilmsRating.BackColor = BackColorError;
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