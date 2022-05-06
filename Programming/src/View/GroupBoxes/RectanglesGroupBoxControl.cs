using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Programming.Service;
using static Programming.Service.Validator;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.GroupBoxes
{
    public partial class RectanglesGroupBoxControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        public RectanglesGroupBoxControl()
        {
            InitializeComponent();
            
            _rectangles = new List<Rectangle>();
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
    }
}