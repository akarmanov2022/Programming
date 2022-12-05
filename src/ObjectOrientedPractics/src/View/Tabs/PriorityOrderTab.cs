using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs;

public partial class PriorityOrderTab : UserControl
{
    private static readonly Color BackColorSuccess = Color.White;

    private static readonly Color BackColorException = Color.LightPink;

    private PriorityOrder _priorityOrder;

    public List<Item> Items { set; get; }

    public PriorityOrderTab()
    {
        InitializeComponent();

        PriorityOrder.DeliveryTimeIntervals.ForEach(interval => DeliveryTimeComboBox.Items.Add(interval));

        foreach (var value in Enum.GetValues(typeof(OrderStatus)))
        {
            StatusComboBox.Items.Add(value);
        }

        _priorityOrder = new PriorityOrder();
        UpdatePage();
    }

    private void UpdatePage()
    {
        IdTextBox.Text = _priorityOrder.Id.ToString();
        CreatedDateTimePicker.Value = _priorityOrder.CreateDate;
        StatusComboBox.SelectedItem = _priorityOrder.Status;
        DeliveryAddressControl.Address = _priorityOrder.DeliveryAddress;
        DeliveryTimeComboBox.SelectedItem = _priorityOrder.DeliveryInterval;
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
            _priorityOrder.DeliveryInterval = DeliveryTimeComboBox.SelectedItem as PriorityOrder.DeliveryTimeInterval;
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
        _priorityOrder = new PriorityOrder();
        UpdatePage();
    }
}