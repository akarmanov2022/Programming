using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;
using static Programming.Service.Validator;

namespace Programming.View.GroupBoxes
{
    public partial class SeasonHandleGroupBoxControl : UserControl
    {
        public SeasonHandleGroupBoxControl()
        {
            InitializeComponent();
            
            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values) ComboBoxSeasons.Items.Add(value);
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
    }
}