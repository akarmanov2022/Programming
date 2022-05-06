using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Enum;
using Programming.Service;
using Programming.View.GroupBoxes;
using static Programming.Service.Validator;

namespace Programming.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var types = new List<Type>()
            {
                typeof(EnumColor),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(Season),
                typeof(TrainingType),
                typeof(Weekday)
            };

            var enumerationGroupBoxControl = new EnumerationGroupBoxControl(types);
            enumerationGroupBoxControl.Dock = DockStyle.Top;
            TabPageEnums.Controls.Add(enumerationGroupBoxControl);

            var weekdayParsingGroupBoxControl = new WeekdayParsingGroupBoxControl(types);
            weekdayParsingGroupBoxControl.Dock = DockStyle.Bottom;
            TabPageEnums.Controls.Add(weekdayParsingGroupBoxControl);

            var seasonHandleGroupBoxControl = new SeasonHandleGroupBoxControl();
            seasonHandleGroupBoxControl.Dock = DockStyle.Bottom;
            TabPageEnums.Controls.Add(seasonHandleGroupBoxControl);

            var rectanglesGroupBoxControl = new RectanglesGroupBoxControl();
            rectanglesGroupBoxControl.Dock = DockStyle.Top;
            TabPageClasses.Controls.Add(rectanglesGroupBoxControl);

            var movieGroupBoxControl = new MovieGroupBoxControl();
            movieGroupBoxControl.Dock = DockStyle.Top;
            TabPageClasses.Controls.Add(movieGroupBoxControl);
        }
    }
}