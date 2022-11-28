using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumerationControl : UserControl
    {
        public EnumerationControl(List<Type> types)
        {
            InitializeComponent();
            foreach (var type in types)
            {
                var item = new ListViewItem(type.Name);
                item.SubItems.Add(type.FullName);
                item.SubItems.Add(type.Assembly.GetName().Name);
                ListBoxValues.Items.Add(item);
            }
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