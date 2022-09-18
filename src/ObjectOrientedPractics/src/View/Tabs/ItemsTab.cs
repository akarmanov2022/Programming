using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using static System.Double;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private static readonly Color BackColorSuccess = Color.White;

        private static readonly Color BackColorException = Color.LightPink;

        private readonly List<Item> _items = new List<Item>();

        private Item _currentItem = new Item();

        public ItemsTab()
        {
            InitializeComponent();

            ItemsRemoveButton.Enabled = false;
            ItemsAddButton.Enabled = false;
        }


        private void SelectedItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = SelectedItemCostTextBox.Text;
                if (IsNullOrWhiteSpace(text)) return;
                var cost = Parse(text);
                _currentItem.Cost = cost;
                SelectedItemCostTextBox.BackColor = BackColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                _currentItem.Cost = NaN;
                SelectedItemCostTextBox.BackColor = BackColorException;
            }
            EnableAddButton();
        }

        private void SelectedItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = SelectedItemNameTextBox.Text;
                if (IsNullOrWhiteSpace(text)) return;
                _currentItem.Name = text;
                SelectedItemNameTextBox.BackColor = BackColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                _currentItem.Name = Empty;
                SelectedItemNameTextBox.BackColor = BackColorException;
            }

            EnableAddButton();
        }

        private void SelectedItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = SelectedItemDescriptionTextBox.Text;
                if (IsNullOrWhiteSpace(text)) return;
                _currentItem.Info = text;
                SelectedItemDescriptionTextBox.BackColor = BackColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                _currentItem.Info = Empty;
                SelectedItemDescriptionTextBox.BackColor = BackColorException;
            }
            EnableAddButton();
        }

        private void ItemsAddButton_Click(object sender, EventArgs e)
        {
            _items.Add(_currentItem);
            _currentItem = new Item();
            UpdateItemsListBox();
            ClearTextBoxes();
            EnableAddButton();
        }

        private void ClearTextBoxes()
        {
            SelectedItemIdTextBox.Clear();
            SelectedItemCostTextBox.Clear();
            SelectedItemNameTextBox.Clear();
            SelectedItemDescriptionTextBox.Clear();
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        private void EnableAddButton()
        {
            ItemsAddButton.Enabled = IsNullOrEmpty(SelectedItemIdTextBox.Text) 
                                     && !IsNaN(_currentItem.Cost) 
                                     && !IsNullOrWhiteSpace(_currentItem.Name) 
                                     && !IsNullOrWhiteSpace(_currentItem.Info);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Item) ItemsListBox.SelectedItem;
            _currentItem = selectedItem;
            UpdateValueInTextBoxes();
            ItemsRemoveButton.Enabled = true;
        }

        private void UpdateValueInTextBoxes()
        {
            SelectedItemIdTextBox.Text = _currentItem.Id.ToString();
            SelectedItemCostTextBox.Text = _currentItem.Cost.ToString(CultureInfo.InvariantCulture);
            SelectedItemNameTextBox.Text = _currentItem.Name;
            SelectedItemDescriptionTextBox.Text = _currentItem.Info;
        }

        private void ItemsRemoveButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            UpdateItemsListBox();
            ClearTextBoxes();
            ItemsRemoveButton.Enabled = false;
            _currentItem = new Item();
        }
    }
}