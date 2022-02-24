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
        private List<Type> _types = new List<Type>();

        public MainForm()
        {
            InitializeComponent();

            _types.AddRange(new[]
            {
                typeof(Color),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(Seasons),
                typeof(TrainingType),
                typeof(Weekday)
            });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var types = _types;
            enumsListBox.Items.AddRange(types.ToArray());
            enumsListBox.SetSelected(0, true);

            var values = Enum.GetValues(typeof(Seasons));
            foreach (var value in values) cbSeasons.Items.Add(value);
        }

        private void enumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            valuesListBox.Items.Clear();
            var item = ((ListBox) sender).SelectedItem;
            var type = (Type) item;
            var values = Enum.GetValues(type);
            foreach (var value in values) valuesListBox.Items.Add(value);
        }

        private void valuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ((ListBox) sender).SelectedItem;
            tbIntValue.Text = item.GetHashCode().ToString();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            var text = tbValueParse.Text;
            var types = _types;

            foreach (var type in types)
            {
                if (!Enum.IsDefined(type, text)) continue;
                var o = Enum.Parse(type, text, true);
                lbTextParse.Text = o + @" - " + o.GetHashCode();
                break;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var item = cbSeasons.SelectedItem;
            switch (item)
            {
                case Seasons.Autumn:
                    tabPageEnums.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Seasons.Spring:
                    tabPageEnums.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Seasons.Winter:
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}