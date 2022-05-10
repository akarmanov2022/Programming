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
            var weekdayParsingGroupBoxControl = new WeekdayParsingControl(types);
            var seasonHandleGroupBoxControl = new SeasonHandleGroupBoxControl();
            var rectanglesGroupBoxControl = new RectanglesControl();
            var movieGroupBoxControl = new MovieControl();
            
            enumerationGroupBoxControl.Dock = DockStyle.Top;
            weekdayParsingGroupBoxControl.Dock = DockStyle.Bottom;
            seasonHandleGroupBoxControl.Dock = DockStyle.Bottom;
            rectanglesGroupBoxControl.Dock = DockStyle.Top;
            movieGroupBoxControl.Dock = DockStyle.Top;
            
            TabPageEnums.Controls.Add(enumerationGroupBoxControl);
            TabPageEnums.Controls.Add(weekdayParsingGroupBoxControl);
            TabPageEnums.Controls.Add(seasonHandleGroupBoxControl);
            TabPageClasses.Controls.Add(rectanglesGroupBoxControl);
            TabPageClasses.Controls.Add(movieGroupBoxControl);
        }
    }
}