using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enum;
using Programming.Service;
using static System.String;
using Color = Programming.Model.Enum.EnumColor;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private static readonly System.Drawing.Color BackColorSuccess = System.Drawing.Color.White;

        private static readonly System.Drawing.Color BackColorError = System.Drawing.Color.LightPink;
        
        private static readonly System.Drawing.Color RectanglePanelBackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        private List<Type> _types;

        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _movies = MovieUtils.GenerateRandomMovies(5);
            _rectanglePanels = new List<Panel>();
            _rectangles = new List<Rectangle>();

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
            ListBoxEnums.Items.AddRange(_types.ToArray());
            ListBoxEnums.SetSelected(0, true);
            
            RectanglesListBox.SelectionMode = SelectionMode.One;

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
            var index = RectangleUtils.FindRectangleWithMaxWidth(rectangles);

            ListBoxClassesRectangles.SelectedIndex = index;
        }

        private void ListBoxClassesRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rectangles = _rectangles;
            var index = ListBoxClassesRectangles.SelectedIndex;
            _currentRectangle = rectangles[index];

            TextBoxClassesRectangleColor.Text = _currentRectangle.Color;
            TextBoxClassesRectangleLength.Text = _currentRectangle.Height.ToString(CultureInfo.InvariantCulture);
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
                _currentRectangle.Height = int.Parse(text);
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
                _currentRectangle.Width = int.Parse(text);
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
            var index = MovieUtils.FindMovieWithMaxRating(movies);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleUtils.GenerateRandomRectangle(CanvaPanel.Width / 2, CanvaPanel.Height / 2);
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(rectangle);

            var panel = new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Width = rectangle.Width,
                Height = rectangle.Height,
                BackColor = RectanglePanelBackColor,
                BorderStyle = BorderStyle.FixedSingle
            };
            _rectanglePanels.Add(panel);
            CanvaPanel.Controls.Add(panel);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            var index = RectanglesListBox.SelectedIndex;
            _rectangles.RemoveAt(index);
            RectanglesListBox.Items.RemoveAt(index);
            
            CanvaPanel.Controls.RemoveAt(index);
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            IdTextBox.Text = Empty;
            XTextBox.Text = Empty;
            YTextBox.Text = Empty;
            WidthTextBox.Text = Empty;
            HeightTextBox.Text = Empty;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((ListBox) sender).SelectedItem;
            if (item != null)
            {
                _currentRectangle = (Rectangle) item;

                IdTextBox.Text = _currentRectangle.Id.ToString();
                XTextBox.Text = _currentRectangle.Center.X.ToString();
                YTextBox.Text = _currentRectangle.Center.Y.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString(CultureInfo.InvariantCulture);
                HeightTextBox.Text = _currentRectangle.Height.ToString(CultureInfo.InvariantCulture);
            }
        }

        private void UpdateRectangles()
        {
            var rectangles = _rectangles;
            var rectangle = rectangles.Find(r => r.Id == _currentRectangle.Id);
            var index = rectangles.IndexOf(rectangle);
            rectangles[index] = _currentRectangle;

            RectanglesListBox.Items.Clear();
            RectanglesListBox.Items.AddRange(rectangles.ToArray());

            _rectangles = rectangles;
        }

        private void XTextBox_Leave(object sender, EventArgs e)
        {
            XTextBox.BackColor = BackColorSuccess;
            if (XTextBox.Text == "") return;
            try
            {
                var x = int.Parse(XTextBox.Text);
                if (x == _currentRectangle.Center.X) return;

                _currentRectangle.Center.X = x;
                UpdateRectangles();
            }
            catch (Exception)
            {
                XTextBox.BackColor = BackColorError;
            }
        }

        private void YTextBox_Leave(object sender, EventArgs e)
        {
            YTextBox.BackColor = BackColorSuccess;
            if (YTextBox.Text == "") return;
            try
            {
                var y = int.Parse(YTextBox.Text);
                if (y == _currentRectangle.Center.Y) return;

                _currentRectangle.Center.Y = y;
                UpdateRectangles();
            }
            catch (Exception)
            {
                YTextBox.BackColor = BackColorError;
            }
        }

        private void WidthTextBox_Leave(object sender, EventArgs e)
        {
            WidthTextBox.BackColor = BackColorSuccess;
            if (WidthTextBox.Text == "") return;
            try
            {
                var width = int.Parse(WidthTextBox.Text);
                if (width == _currentRectangle.Width) return;

                _currentRectangle.Width = width;
                UpdateRectangles();
            }
            catch (Exception)
            {
                WidthTextBox.BackColor = BackColorError;
            }
        }

        private void HeightTextBox_Leave(object sender, EventArgs e)
        {
            HeightTextBox.BackColor = BackColorSuccess;
            if (HeightTextBox.Text == "") return;
            try
            {
                var height = int.Parse(HeightTextBox.Text);
                if (height == _currentRectangle.Height) return;

                _currentRectangle.Height = height;
                UpdateRectangles();
            }
            catch (Exception)
            {
                HeightTextBox.BackColor = BackColorError;
            }
        }

        private void FindCollisions()
        {
            
        }
    }
}