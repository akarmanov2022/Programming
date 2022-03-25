using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enum;
using Color = Programming.Model.Enum.EnumColor;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private static readonly Random Random = new Random();

        private List<Type> _types;

        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;

        private Film[] _films;
        private Film _currentFilm;
        private static readonly System.Drawing.Color BackColorSuccess = System.Drawing.Color.White;
        private static readonly System.Drawing.Color BackColorError = System.Drawing.Color.LightPink;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _rectangles = CreateRandomRectangles(5);
            _films = CreateRandomFilms(5);

            _types = new List<Type>()
            {
                typeof(Color),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(Season),
                typeof(TrainingType),
                typeof(Weekday)
            };

            ListBoxClassesFilms.Items.AddRange(_films);
            ListBoxClassesRectangles.Items.AddRange(_rectangles);
            ListBoxEnums.Items.AddRange(_types.ToArray());
            ListBoxEnums.SetSelected(0, true);

            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values) ComboBoxSeasons.Items.Add(value);
        }

        private static Film[] CreateRandomFilms(int count)
        {
            var films = new Film[count];
            var genres = Enum.GetValues(typeof(Genre));
            for (var i = 0; i < films.Length; i++)
            {
                var genreRandomIndex = Random.Next(0, genres.Length);
                var genre = genres.GetValue(genreRandomIndex);
                films[i] = new Film
                {
                    Genre = genre.ToString(),
                    Duration = Random.Next(200),
                    Year = Random.Next(Film.MinYear, DateTime.Now.Year),
                    Rating = Math.Round(Random.NextDouble(), 2),
                    Name = $"{genre}Film{Random.Next(100)}"
                };
            }

            return films;
        }

        private int FindRectangleWithMaxWidth()
        {
            var rectangles = _rectangles;
            var maxWidth = rectangles[0].Width;
            var rectangleId = 0;
            for (var i = 1; i < rectangles.Length; i++)
            {
                if (!(maxWidth < rectangles[i].Width)) continue;

                maxWidth = rectangles[i].Width;
                rectangleId = i;
            }

            return rectangleId;
        }

        private static Rectangle[] CreateRandomRectangles(int count)
        {
            var colors = Enum.GetValues(typeof(Color));
            var rectangles = new Rectangle[count];
            for (var i = 0; i < rectangles.Length; i++)
            {
                var colorId = Random.Next(0, colors.Length);
                rectangles[i] = new Rectangle
                {
                    Length = Math.Round(Random.NextDouble() * 100, 2),
                    Width = Math.Round(Random.NextDouble() * 100, 2),
                    Color = colors.GetValue(colorId).ToString()
                };
            }

            return rectangles;
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
            var index = FindRectangleWithMaxWidth();

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
            var films = _films;
            var index = ListBoxClassesFilms.SelectedIndex;
            _currentFilm = films[index];

            TextBoxClassesFilmsDuration.Text = _currentFilm.Duration.ToString();
            TextBoxClassesFilmsYear.Text = _currentFilm.Year.ToString();
            TextBoxClassesFilmsName.Text = _currentFilm.Name;
            TextBoxClassesFilmsGenre.Text = _currentFilm.Genre;
            TextBoxClassesFilmsRating.Text = _currentFilm.Rating.ToString(CultureInfo.InvariantCulture);
        }

        private void ButtonClassesFilmsFind_Click(object sender, EventArgs e)
        {
            var index = FindFilmWithMaxRating();
            ListBoxClassesFilms.SelectedIndex = index;
        }

        private int FindFilmWithMaxRating()
        {
            var films = _films;
            var maxRating = films[0].Rating;
            var filmId = 0;
            for (var i = 1; i < films.Length; i++)
            {
                if (!(maxRating < films[i].Rating)) continue;
                maxRating = films[i].Rating;
                filmId = i;
            }

            return filmId;
        }

        private void TextBoxClassesFilmsDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesFilmsDuration.BackColor = BackColorSuccess;
                var text = TextBoxClassesFilmsDuration.Text;
                _currentFilm.Duration = int.Parse(text);
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
                _currentFilm.Year = int.Parse(text);
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
                _currentFilm.Rating = double.Parse(text.Replace('.', ','));
            }
            catch (Exception)
            {
                TextBoxClassesFilmsRating.BackColor = BackColorError;
            }
        }

        private void TextBoxClassesFilmsName_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = TextBoxClassesFilmsName.Text;
        }

        private void TextBoxClassesFilmsGenre_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = TextBoxClassesFilmsGenre.Text;
        }
    }
}