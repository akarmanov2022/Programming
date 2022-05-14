using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Programming.Service;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Panels
{
    public partial class RectangleCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        public RectangleCollisionControl()
        {
            InitializeComponent();
        }

        private void RectangleCollisionControl_Load(object sender, EventArgs e)
        {
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
            
            RectanglesListBox.SelectionMode = SelectionMode.One;
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
            var panel = new Panel
            {
                Location = new Point(rectangle.Center.X, rectangle.Center.Y),
                Width = rectangle.Width,
                Height = rectangle.Height,
                BackColor = rectangle.Color,
                BorderStyle = BorderStyle.FixedSingle,
            };
            panel.Click += Rectangle_Click;
            return panel;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            var panel = (Panel) sender;
            var index = CanvaPanel.Controls.IndexOf(panel);
            RectanglesListBox.SetSelected(index, true);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex >= 0)
            { 
                var index = RectanglesListBox.SelectedIndex;

                ClearRectangleInfo(index);
                FindCollisions();
                
                RectanglesListBox.SetSelected(0, true);
            }
        }

        private void ClearRectangleInfo(int rectangleId)
        {
            IdTextBox.Clear();
            XTextBox.Clear();
            YTextBox.Clear();
            WidthTextBox.Clear();
            HeightTextBox.Clear();
            
            _rectangles.RemoveAt(rectangleId);
            RectanglesListBox.Items.RemoveAt(rectangleId);
            _rectanglePanels.RemoveAt(rectangleId);
            CanvaPanel.Controls.RemoveAt(rectangleId);
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            _currentRectangle = new Rectangle(selectedRectangle);

            IdTextBox.Text = _currentRectangle.Id.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString(CultureInfo.InvariantCulture);
            HeightTextBox.Text = _currentRectangle.Height.ToString(CultureInfo.InvariantCulture);
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

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XTextBox.BackColor = Validator.BackColorSuccess;
                if (XTextBox.Text != string.Empty)
                {
                    var xValue = int.Parse(XTextBox.Text);
                    if (_currentRectangle.Center.X != xValue)
                    {
                        _currentRectangle.Center.X = xValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                XTextBox.BackColor = Validator.BackColorException;
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YTextBox.BackColor = Validator.BackColorSuccess;
                if (YTextBox.Text != string.Empty)
                {
                    var yValue = int.Parse(YTextBox.Text);
                    if (_currentRectangle.Center.Y != yValue)
                    {
                        _currentRectangle.Center.Y = yValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                YTextBox.BackColor = Validator.BackColorException;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = Validator.BackColorSuccess;
                if (WidthTextBox.Text != string.Empty)
                {
                    var widthValue = int.Parse(WidthTextBox.Text);
                    if (_currentRectangle.Width != widthValue)
                    {
                        _currentRectangle.Width = widthValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                WidthTextBox.BackColor = Validator.BackColorException;
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = Validator.BackColorSuccess;
                if (HeightTextBox.Text != string.Empty)
                {
                    var heightValue = int.Parse(HeightTextBox.Text);
                    if (_currentRectangle.Height != heightValue)
                    {
                        _currentRectangle.Height = heightValue;
                        UpdateRectangleInfo(_currentRectangle);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                HeightTextBox.BackColor = Validator.BackColorException;
            }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                var updateRectangle = new Rectangle(rectangle);
                var oldRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                var differenceWidth = Math.Abs(oldRectangle.Width - updateRectangle.Width) / 2;
                var differenceHeight = Math.Abs(oldRectangle.Height - updateRectangle.Height) / 2;

                if (updateRectangle.Center.Equals(oldRectangle.Center))
                {
                    updateRectangle.Center.X = oldRectangle.Width >= updateRectangle.Width
                        ? oldRectangle.Center.X + differenceWidth
                        : oldRectangle.Center.X - differenceWidth;

                    updateRectangle.Center.Y = oldRectangle.Height >= updateRectangle.Height
                        ? oldRectangle.Center.Y + differenceHeight
                        : oldRectangle.Center.Y - differenceHeight;
                }

                var index = _rectangles.FindIndex(r => r.Equals(updateRectangle));
                _rectangles[index] = updateRectangle;
                
                UpdatePanel(updateRectangle, index);
                FindCollisions();
            }
        }

        private void UpdatePanel(Rectangle rectangle, int index)
        {
            var control = CanvaPanel.Controls[index];
            control.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            control.Width = rectangle.Width;
            control.Height = rectangle.Height;
        }

        private void FindCollisions()
        {
            foreach (Control control in CanvaPanel.Controls)
                control.BackColor = Rectangle.DefaultRectangleColor;

            var rectangles = _rectangles;
            for (var i = 0; i < rectangles.Count; i++)
            for (var j = 0; j < rectangles.Count; j++)
            {
                if (Equals(rectangles[i], rectangles[j])) continue;

                if (CollisionManager.IsCollision(rectangles[i], rectangles[j]))
                {
                    _rectangles[i].Color = _rectanglePanels[i].BackColor = CanvaPanel.Controls[i].BackColor = Rectangle.CollisionRectangleColor;
                    _rectangles[j].Color = _rectanglePanels[j].BackColor = CanvaPanel.Controls[j].BackColor = Rectangle.CollisionRectangleColor;
                }
            }
        }
    }
}