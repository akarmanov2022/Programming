using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Programming.Model.Enum;
using Programming.View.Panels;

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

            var enumerationGroupBoxControl = new EnumerationControl(types);
            enumerationGroupBoxControl.Dock = DockStyle.Top;
            TabPageEnums.Controls.Add(enumerationGroupBoxControl);

            var weekdayParsingGroupBoxControl = new WeekdayParsingControl(types);
            weekdayParsingGroupBoxControl.Dock = DockStyle.Bottom;
            TabPageEnums.Controls.Add(weekdayParsingGroupBoxControl);

            var seasonHandleGroupBoxControl = new SeasonHandleGroupBoxControl();
            seasonHandleGroupBoxControl.Dock = DockStyle.Bottom;
            TabPageEnums.Controls.Add(seasonHandleGroupBoxControl);

            var rectanglesGroupBoxControl = new RectanglesControl();
            rectanglesGroupBoxControl.Dock = DockStyle.Top;
            TabPageClasses.Controls.Add(rectanglesGroupBoxControl);

            var movieGroupBoxControl = new MovieControl();
            movieGroupBoxControl.Dock = DockStyle.Top;
            TabPageClasses.Controls.Add(movieGroupBoxControl);
        }
    }
}