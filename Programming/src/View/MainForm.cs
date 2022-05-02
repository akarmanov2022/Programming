using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enum;
using Programming.Service;
using static System.String;
using static Programming.Model.Rectangle;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private static readonly Color BackColorSuccess = Color.White;

        private static readonly Color BackColorException = Color.LightPink;

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
            _movies = MovieFactory.GenerateRandomMovies(5);
            _rectanglePanels = new List<Panel>();
            _rectangles = new List<Rectangle>();

            _types = new List<Type>()
            {
                typeof(EnumColor),
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
            var index = RectangleFactory.FindRectangleWithMaxWidth(rectangles);

            ListBoxClassesRectangles.SelectedIndex = index;
        }

        private void ListBoxClassesRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rectangles = _rectangles;
            var index = ListBoxClassesRectangles.SelectedIndex;
            _currentRectangle = rectangles[index];

            TextBoxClassesRectangleColor.Text = _currentRectangle.Color.Name;
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
                TextBoxClassesRectangleLength.BackColor = BackColorException;
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
                TextBoxClassesRectangleWidth.BackColor = BackColorException;
            }
        }

        private void TextBoxClassesRectangleColor_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = Color.FromName(TextBoxClassesRectangleColor.Text);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.GenerateRandomRectangle(CanvaPanel.Width, CanvaPanel.Height);

            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add(rectangle);

            var panel = CreatePanel(rectangle);
            _rectanglePanels.Add(panel);
            CanvaPanel.Controls.Add(panel);

            FindCollisions();
        }

        private Panel CreatePanel(Rectangle rectangle)
        {
            return new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Width = rectangle.Width,
                Height = rectangle.Height,
                BackColor = rectangle.Color,
                BorderStyle = BorderStyle.FixedSingle
            };
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                var rectangle = (Rectangle) RectanglesListBox.SelectedItem;
                var index = RectanglesListBox.SelectedIndex;

                _rectangles.Remove(rectangle);
                RectanglesListBox.Items.Remove(rectangle);
                _rectanglePanels.RemoveAt(index);
                CanvaPanel.Controls.RemoveAt(index);

                FindCollisions();
                ClearRectangleInfo();
            }
        }

        private void ClearRectangleInfo()
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

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Resources.rectangle_add_24x24_uncolor;
        }

        private void ClearButton_MouseEnter(object sender, EventArgs e)
        {
            ClearButton.Image = Resources.rectangle_remove_24x24;
        }

        private void ClearButton_MouseLeave(object sender, EventArgs e)
        {
            ClearButton.Image = Resources.rectangle_remove_24x24_uncolor;
        }

        private void EditRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            EditRectangleButton.Image = Resources.rectangle_edit_24x24;
        }

        private void EditRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            EditRectangleButton.Image = Resources.rectangle_edit_24x24_uncolor;
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XTextBox.BackColor = BackColorSuccess;
                if (XTextBox.Text != Empty)
                {
                    var xValue = int.Parse(XTextBox.Text);
                    _currentRectangle.Center.X = xValue;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                XTextBox.BackColor = BackColorException;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YTextBox.BackColor = BackColorSuccess;
                if (YTextBox.Text != Empty)
                {
                    var yValue = int.Parse(YTextBox.Text);
                    _currentRectangle.Center.Y = yValue;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                YTextBox.BackColor = BackColorException;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = BackColorSuccess;
                if (WidthTextBox.Text != Empty)
                {
                    var widthValue = int.Parse(WidthTextBox.Text);
                    _currentRectangle.Width = widthValue;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                WidthTextBox.BackColor = BackColorException;
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = BackColorSuccess;
                if (HeightTextBox.Text != Empty)
                {
                    var heightValue = int.Parse(HeightTextBox.Text);
                    _currentRectangle.Height = heightValue;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                HeightTextBox.BackColor = BackColorException;
            }
        }

        private void EditRectangleButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            {
                XTextBox.Text = Empty;
                YTextBox.Text = Empty;
                WidthTextBox.Text = Empty;
                HeightTextBox.Text = Empty;

                var rectangle = (Rectangle) RectanglesListBox.SelectedItem;
                UpdateRectangleInfo(rectangle);
            }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                rectangle.Center = _currentRectangle.Center;
                rectangle.Color = _currentRectangle.Color;
                rectangle.Height = _currentRectangle.Height;
                rectangle.Width = _currentRectangle.Width;

                var rectangleId = _rectangles.FindIndex(r => r.Id == rectangle.Id);

                _rectangles[rectangleId] = rectangle;
                RectanglesListBox.Items[rectangleId] = rectangle;


                var panel = CreatePanel(rectangle);
                _rectanglePanels[rectangleId] = panel;
                CanvaPanel.Controls.RemoveAt(rectangleId);
                CanvaPanel.Controls.Add(panel);
                
                FindCollisions();
            }
        }

        private void FindCollisions()
        {
            foreach (Control control in CanvaPanel.Controls)
                control.BackColor = DefaultRectangleColor;

            var rectangles = _rectangles;
            for (var i = 0; i < rectangles.Count; i++)
            for (var j = 0; j < rectangles.Count; j++)
            {
                if (rectangles[i] == rectangles[j]) continue;

                if (CollisionManager.IsCollision(rectangles[i], rectangles[j]))
                {
                    _rectangles[i].Color = _rectanglePanels[i].BackColor = CanvaPanel.Controls[i].BackColor = CollisionRectangleColor;
                    _rectangles[j].Color = _rectanglePanels[j].BackColor = CanvaPanel.Controls[j].BackColor = CollisionRectangleColor;
                }
            }
        }
    }
}