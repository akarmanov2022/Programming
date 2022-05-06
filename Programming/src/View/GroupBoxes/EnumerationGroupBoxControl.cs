using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.GroupBoxes
{
    public partial class EnumerationGroupBoxControl : UserControl
    {
        public EnumerationGroupBoxControl(List<Type> types)
        {
            InitializeComponent();
            
            ListBoxEnums.Items.AddRange(types.ToArray());
            ListBoxEnums.SetSelected(0, true);
        }

        private void ListBoxEnums_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxValues.Items.Clear();
            var item = ListBoxEnums.SelectedItem;
            var type = (Type) item;
            var values = type.GetEnumValues();
            foreach (var value in values) ListBoxValues.Items.Add(value);
        }

        private void ListBoxValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ListBoxValues.SelectedItem;
            TextBoxIntValue.Text = ((int) item).ToString();
        }
    }
}