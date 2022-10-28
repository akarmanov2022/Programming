using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
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

        private void UpdateCustomersComboBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var customer in Customers)
            {
                CustomersComboBox.Items.Add(customer);
            }
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (var item in Items)
            {
                ItemsListBox.Items.Add(item);
            }
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = (Customer) CustomersComboBox.SelectedItem;
            if (customer == null)
            {
                _currentCustomer = null;
                return;
            }
            _currentCustomer = customer;
            UpdateCartListBox();
        }

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

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            var item = (Item) ItemsListBox.SelectedItem;
            if (_currentCustomer == null || item == null) return;
            _currentCustomer.Cart.Items.Add(item);
            UpdateCartListBox();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            var item = (Item) CartListBox.SelectedItem;
            if (_currentCustomer == null || item == null) return;
            _currentCustomer.Cart.Items.Remove(item);
            UpdateCartListBox();
        }
    }
}