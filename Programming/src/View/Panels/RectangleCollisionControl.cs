using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Programming.Service;
using static Programming.Model.Rectangle;
using static Programming.Service.Validator;
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
                var index = RectanglesListBox.SelectedIndex;

                ClearRectangleInfo(index);
                FindCollisions();
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
                if (XTextBox.Text != string.Empty)
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
                if (YTextBox.Text != string.Empty)
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
                if (WidthTextBox.Text != string.Empty)
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
                if (HeightTextBox.Text != string.Empty)
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
                XTextBox.Text = string.Empty;
                YTextBox.Text = string.Empty;
                WidthTextBox.Text = string.Empty;
                HeightTextBox.Text = string.Empty;

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
                
                UpdatePanel(rectangle, rectangleId);
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