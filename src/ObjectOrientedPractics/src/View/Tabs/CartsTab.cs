using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs;

public partial class CartsTab : UserControl
{
    private List<Item> _items;

    private List<Customer> _customers;

    private Customer _currentCustomer;

    public List<Item> Items
    {
        get => _items;
        set
        {
            _items = value;
            UpdateItemsListBox();
        }
    }

    public List<Customer> Customers
    {
        get => _customers;
        set
        {
            _customers = value;
            UpdateCustomersComboBox();
        }
    }

    public CartsTab()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Полностью обновляет данные на форме.
    /// </summary>
    public void RefreshData()
    {
        _currentCustomer = null;
        UpdateCartListBox();
        UpdateCustomersComboBox();
        UpdateItemsListBox();
    }

    /// <summary>
    /// Обновляет данные в <see cref="CustomersComboBox"/>.
    /// </summary>
    private void UpdateCustomersComboBox()
    {
        if (_customers == null) return;
        CustomersComboBox.Items.Clear();
        foreach (var customer in _customers)
        {
            CustomersComboBox.Items.Add(customer);
        }
    }

    /// <summary>
    /// Обновляет данные в <see cref="ItemsListBox"/>.
    /// </summary>
    private void UpdateItemsListBox()
    {
        if (_items == null) return;
        ItemsListBox.Items.Clear();
        foreach (var item in Items)
        {
            ItemsListBox.Items.Add(item);
        }
    }

    /// <summary>
    /// Обновляет данные в <see cref="CartListBox"/>.
    /// </summary>
    private void UpdateCartListBox()
    {
        if (_currentCustomer == null) return;
        CartListBox.Items.Clear();
        foreach (var item in _currentCustomer.Cart.Items)
        {
            CartListBox.Items.Add(item);
        }

        AmountValueLabel.Text = _currentCustomer.Cart.Amount.ToString(CultureInfo.CurrentCulture);
    }

    private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        var customer = (Customer)CustomersComboBox.SelectedItem;
        if (customer == null)
        {
            _currentCustomer = null;
            return;
        }

        _currentCustomer = customer;
        UpdateCartListBox();
        CalculateDiscounts();
        UpdateDiscountsCheckedListBox();
    }

    private void UpdateDiscountsCheckedListBox()
    {
        DiscountsCheckedListBox.Items.Clear();
        foreach (var discount in _currentCustomer.Discounts)
        {
            DiscountsCheckedListBox.Items.Add(discount, discount.Active);
        }
    }

    private void AddToCartButton_Click(object sender, EventArgs e)
    {
        var item = (Item)ItemsListBox.SelectedItem;
        if (_currentCustomer == null || item == null) return;
        _currentCustomer.Cart.Items.Add(item);
        CalculateDiscounts();
        UpdateCartListBox();
    }

    private void RemoveItemButton_Click(object sender, EventArgs e)
    {
        var item = (Item)CartListBox.SelectedItem;
        if (_currentCustomer == null || item == null) return;
        _currentCustomer.Cart.Items.Remove(item);
        CalculateDiscounts();
        UpdateCartListBox();
    }

    private void CreateOrderButton_Click(object sender, EventArgs e)
    {
        if (_currentCustomer == null) return;
        var items = _currentCustomer.Cart.Items;
        if (items.Count == 0)
        {
            MessageBox.Show(@"The cart cannot be empty!", @"Info!", MessageBoxButtons.OK);
            return;
        }

        var order = _currentCustomer.IsPriority
            ? new PriorityOrder()
            : new Order();
        foreach (var item in items)
        {
            order.Items.Add(item);
        }
        ApplyDiscounts(order);
        UpdateDiscounts(order);
        order.DeliveryAddress = _currentCustomer.Address;
        order.History.Add(DateTime.Now, order.Status);
        _currentCustomer.Orders.Add(order);
        items.Clear();
        CartListBox.Items.Clear();
        AmountValueLabel.Text = @"0";
        TotalValuelabel.Text = @"0";
        UpdateDiscountsCheckedListBox();
    }

    private void UpdateDiscounts(Order order)
    {
        var orderItems = order.Items;
        _currentCustomer.Discounts.ForEach(discount => discount.Update(orderItems));
    }

    private void ApplyDiscounts(Order order)
    {
        var orderItems = order.Items;
        var sum = _currentCustomer.Discounts.Where(discount => discount.Active)
            .Sum(discount => discount.Apply(orderItems));
        order.DiscountAmount = sum;
    }

    private void ClearCartButton_Click(object sender, EventArgs e)
    {
        if (_currentCustomer == null) return;
        var items = _currentCustomer.Cart.Items;
        items.Clear();
        CartListBox.Items.Clear();
        AmountValueLabel.Text = @"0";
        TotalValuelabel.Text = @"0";
        CalculateDiscounts();
    }

    private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        if (DiscountsCheckedListBox.Items[e.Index] is not IDiscount discount) return;
        discount.Active = e.NewValue == CheckState.Checked;
        CalculateDiscounts();
    }

    private void CalculateDiscounts()
    {
        var cartItems = _currentCustomer.Cart.Items;
        var sum = cartItems.Sum(item => item.Cost);
        var discountSum = _currentCustomer.Discounts.Where(discount => discount.Active)
            .Sum(discount => discount.Calculate(cartItems));
        var totalSum = sum - discountSum;
        DiscountAmountValueLabel.Text = discountSum.ToString(CultureInfo.InvariantCulture);
        TotalValuelabel.Text = totalSum.ToString(CultureInfo.InvariantCulture);
    }
}