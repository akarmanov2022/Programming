using System;
using System.Linq;
using System.Windows.Forms;
using Programming.model;

namespace Programming.view
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            enumsListBox.Items.AddRange(new object[]
            {
                typeof(Color),
                typeof(Genre),
                typeof(SmartphoneCompany),
                typeof(TimeOfYear),
                typeof(TrainingType),
                typeof(Weekday)
            });
            enumsListBox.SetSelected(0, true);
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
    }
}