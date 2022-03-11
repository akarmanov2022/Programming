using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Programming.model;
using Color = Programming.model.Color;

namespace Programming.view
{
    public partial class MainForm : Form
    {
        private List<Type> _types;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _types = new List<Type>()
            {
                typeof(Color),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(Season),
                typeof(TrainingType),
                typeof(Weekday)
            };

            var types = _types;
            ListBoxEnums.Items.AddRange(types.ToArray());
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

            foreach (var enumValue in from type in types where Enum.IsDefined(type, text) select Enum.Parse(type, text, true))
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
                    BackColor = System.Drawing.Color.White;
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Season.Winter:
                    BackColor = System.Drawing.Color.White;
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}