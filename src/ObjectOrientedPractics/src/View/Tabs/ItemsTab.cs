using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;
using static System.Double;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private static readonly Color BackColorSuccess = Color.White;

        private static readonly Color BackColorException = Color.LightPink;

        private Item _currentItem = new Item();

        public List<Item> Items { get; set; } = new List<Item>();

        public ItemsTab()
        {
            InitializeComponent();

            ItemsRemoveButton.Enabled = false;
            SelectedItemCategoryComboBox.Sorted = true;

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                SelectedItemCategoryComboBox.Items.Add(category);
            }
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
        }

        private void SelectedItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (SelectedItemCategoryComboBox.SelectedIndex == -1) return;
                var category = (Category)SelectedItemCategoryComboBox.SelectedItem;
                _currentItem.Category = category;
                SelectedItemCategoryComboBox.BackColor = BackColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                _currentItem.Category = null;
                SelectedItemCategoryComboBox.BackColor = BackColorException;
            }
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
        }

        private void ItemsAddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            Items.Add(_currentItem);
            UpdateItemsListBox();
            ClearFields();
        }

        private void ClearFields()
        {
            SelectedItemIdTextBox.Clear();
            SelectedItemCostTextBox.Clear();
            SelectedItemNameTextBox.Clear();
            SelectedItemDescriptionTextBox.Clear();
            SelectedItemCategoryComboBox.SelectedIndex = -1;
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Item)ItemsListBox.SelectedItem;
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
            SelectedItemCategoryComboBox.SelectedItem = _currentItem.Category;
        }

        private void ItemsRemoveButton_Click(object sender, EventArgs e)
        {
            Items.Remove(_currentItem);
            UpdateItemsListBox();
            ClearFields();
            ItemsRemoveButton.Enabled = false;
            _currentItem = new Item();
        }

        private void ItemsRandomButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            Items = ItemFactory.RandomGenerate(random.Next(10, 100));
            UpdateItemsListBox();
            ClearFields();
        }
    }
}