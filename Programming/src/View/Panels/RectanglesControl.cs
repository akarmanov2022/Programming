using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Programming.Service;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        public RectanglesControl()
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
                TextBoxClassesRectangleLength.BackColor = Validator.BackColorSuccess;
                var text = TextBoxClassesRectangleLength.Text;
                _currentRectangle.Height = int.Parse(text);
            }
            catch (Exception)
            {
                TextBoxClassesRectangleLength.BackColor = Validator.BackColorException;
            }
        }

        private void TextBoxClassesRectangleWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBoxClassesRectangleWidth.BackColor = Validator.BackColorSuccess;
                var text = TextBoxClassesRectangleWidth.Text;
                _currentRectangle.Width = int.Parse(text);
            }
            catch (Exception)
            {
                TextBoxClassesRectangleWidth.BackColor = Validator.BackColorException;
            }
        }

        private void TextBoxClassesRectangleColor_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = Color.FromName(TextBoxClassesRectangleColor.Text);
        }
        
        private void TextBox_KeyPressCancel(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}