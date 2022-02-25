using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.model;
using Color = Programming.model.Color;

namespace Programming.view
{
    public partial class MainForm : Form
    {
        private List<Type> _types = new List<Type>();

        public MainForm()
        {
            InitializeComponent();

            _types.AddRange(new[]
            {
                typeof(Color),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(Season),
                typeof(TrainingType),
                typeof(Weekday)
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var types = _types;
            enumsListBox.Items.AddRange(types.ToArray());
            enumsListBox.SetSelected(0, true);

            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values) cbSeasons.Items.Add(value);
        }

        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            var item = ((ListBox) sender).SelectedItem;
            var type = (Type) item;
            var values = type.GetEnumValues();
            foreach (var value in values) valuesListBox.Items.Add(value);
        }

        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((ListBox) sender).SelectedItem;
            tbIntValue.Text = ((int) item).ToString();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var text = tbValueParse.Text;
            var types = _types;

            foreach (var type in types)
            {
                if (!Enum.IsDefined(type, text)) continue;
                var o = Enum.Parse(type, text, true);
                lbTextParse.Text = o + @" - " + (int) o;
                break;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var item = cbSeasons.SelectedItem;
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