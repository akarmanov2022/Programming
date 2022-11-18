using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using static ObjectOrientedPractics.Model.PriorityOrder;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrderTab : UserControl
    {
        private static readonly Color BackColorSuccess = Color.White;

        private static readonly Color BackColorException = Color.LightPink;

        private PriorityOrder _priorityOrder;

        public List<Item> Items { set; get; }

        public PriorityOrderTab()
        {
            InitializeComponent();
            
            DeliveryTimeComboBox.Items.AddRange(new object[]
            {
                new DeliveryTimeInterval("09:00 - 11:00"),
                new DeliveryTimeInterval("11:00 - 13:00"),
                new DeliveryTimeInterval("13:00 - 15:00"),
                new DeliveryTimeInterval("15:00 - 17:00"),
                new DeliveryTimeInterval("17:00 - 19:00")
            });

            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(value);
            }

            _priorityOrder = new PriorityOrder(DateTime.Now, @"00:00 - 00:00");
            UpdatePage();
        }

        private void UpdatePage()
        {
            IdTextBox.Text = _priorityOrder.Id.ToString();
            CreatedDateTimePicker.Value = _priorityOrder.CreateDate;
            StatusComboBox.SelectedItem = _priorityOrder.Status;
            DeliveryAddressControl.Address = _priorityOrder.DeliveryAddress;
            UpdateItemsListBox();
        }

        private void UpdateItemsListBox()
        {
            OrderItemsListBox.Items.Clear();
            AmountValueLabel.Text = _priorityOrder.Items.Sum(item => item.Cost).ToString(CultureInfo.InvariantCulture);
            _priorityOrder.Items.ForEach(item => OrderItemsListBox.Items.Add(item));
        }

        private void DeliveryTimeComboBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DeliveryTimeComboBox.BackColor = BackColorSuccess;
                _priorityOrder.DeliveryInterval = DeliveryTimeInterval.ValueOf(DeliveryTimeComboBox.Text);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                DeliveryTimeComboBox.BackColor = BackColorException;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var index = random.Next(0, Items.Count - 1);
            _priorityOrder.Items.Add(Items[index]);
            UpdateItemsListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)OrderItemsListBox.SelectedItem;
            _priorityOrder.Items.Remove(selectedItem);
            UpdateItemsListBox();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder(DateTime.Now, @"00:00 - 00:00");
            UpdatePage();
        }
    }
}