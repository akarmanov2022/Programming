using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using static System.String;

namespace ObjectOrientedPractics.View.Controls;

public partial class OrderControl : UserControl
{
    private static readonly Color BackColorSuccess = Color.White;

    private static readonly Color BackColorException = Color.LightPink;

    private Order _order;

    public Order Order
    {
        get => _order;
        set
        {
            _order = value as PriorityOrder ?? value;
            UpdateFields();
        }
    }

    public OrderControl()
    {
        InitializeComponent();

        PriorityOptionPanel.Visible = false;
        foreach (var value in Enum.GetValues(typeof(OrderStatus)))
        {
            StatusComboBox.Items.Add(value);
        }

        PriorityOrder.DeliveryTimeIntervals.ForEach(interval => DeliveryTimeComboBox.Items.Add(interval));
    }

    /// <summary>
    /// Очищает поля в <see cref="OrderControl"/>.
    /// </summary>
    public void Clear()
    {
        Order = null;
        IdTextBox.Text = Empty;
        CreatedDateTimePicker.Value = DateTime.Now;
        StatusComboBox.SelectedIndex = -1;
        DeliveryAddressControl.Clear();
        OrderItemsListBox.Items.Clear();
        AmountValueLabel.Text = @"0";
    }

    /// <summary>
    /// Обновляет поля в <see cref="OrderControl"/>.
    /// </summary>
    private void UpdateFields()
    {
        if (_order == null) return;
        IdTextBox.Text = _order.Id.ToString();
        CreatedDateTimePicker.Value = _order.CreateDate;
        StatusComboBox.SelectedItem = _order.Status;
        DeliveryAddressControl.Address = _order.DeliveryAddress;
        AmountValueLabel.Text = _order.Amount.ToString(CultureInfo.CurrentCulture);
        OrderItemsListBox.Items.Clear();
        foreach (var item in _order.Items)
        {
            OrderItemsListBox.Items.Add(item);
        }

        switch (_order)
        {
            case PriorityOrder priorityOrder:
                PriorityOptionPanel.Visible = true;
                DeliveryTimeComboBox.SelectedItem = priorityOrder.DeliveryInterval;
                break;
            default:
                PriorityOptionPanel.Visible = false;
                DeliveryTimeComboBox.SelectedIndex = -1;
                break;
        }
    }

    private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (StatusComboBox.SelectedIndex == -1 || Order == null) return;
        var status = (OrderStatus)StatusComboBox.SelectedItem;
        if (status == Order.Status) return;
        Order.Status = status;
        Order.History.Add(DateTime.Now, status);
        ((OrdersTab)Parent).UpdateOrders();
    }

    private void DeliveryTimeComboBox_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (!(Order is PriorityOrder priorityOrder)) return;
            DeliveryTimeComboBox.BackColor = BackColorSuccess;
            priorityOrder.DeliveryInterval =
                DeliveryTimeComboBox.SelectedItem as PriorityOrder.DeliveryTimeInterval;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            DeliveryTimeComboBox.BackColor = BackColorException;
        }
    }
}