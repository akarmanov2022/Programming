using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.GroupBoxes
{
    public partial class WeekdayParsingGroupBoxControl : UserControl
    {
        private List<Type> _types;

        public WeekdayParsingGroupBoxControl(List<Type> types)
        {
            InitializeComponent();
            _types = types;
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
    }
}