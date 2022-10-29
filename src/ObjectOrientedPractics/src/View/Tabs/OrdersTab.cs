using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;

        private List<Order> Orders { set; get; } = new List<Order>();

        private Order _currentOrder;

        public List<Customer> Customers
        {
            set
            {
                _customers = value;
                UpdateOrders();
            }
            get => _customers;
        }

        public OrdersTab()
        {
            InitializeComponent();

            foreach (var value in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(value);
            }
        }

        public void RefreshData()
        {
            _currentOrder = null;
            ClearFields();
            UpdateOrders();
        }

        private void ClearFields()
        {
            IdTextBox.Text = Empty;
            CreatedDateTimePicker.Value = DateTime.Now;
            StatusComboBox.SelectedIndex = -1;
            DeliveryAddressControl.Clear();
            OrderItemsListBox.Items.Clear();
            AmountValueLabel.Text = @"0";
        }

        public void UpdateOrders()
        {
            if (_customers == null) return;
            var currentRowIndex = 0;
            if (OrdersDataGridView.CurrentRow != null) currentRowIndex = OrdersDataGridView.CurrentRow.Index;
            OrdersDataGridView.Rows.Clear();
            Orders.Clear();

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    Orders.Add(order);
                    OrdersDataGridView.Rows.Add(
                        new DataGridViewRow()
                        {
                            Cells =
                            {
                                new DataGridViewTextBoxCell() { Value = order.Id },
                                new DataGridViewTextBoxCell() { Value = order.CreateDate },
                                new DataGridViewTextBoxCell() { Value = order.Status },
                                new DataGridViewTextBoxCell() { Value = customer.Fullname },
                                new DataGridViewTextBoxCell() { Value = order.DeliveryAddress.ToString() },
                                new DataGridViewTextBoxCell() { Value = order.Amount },
                            }
                        });
                }
            }

            OrdersDataGridView.Rows[currentRowIndex].Selected = true;
        }

        private Order GetOrderById(int id)
        {
            return Orders.Find(order => id.Equals(order.Id));
        }

        private void UpdateFields()
        {
            if (_currentOrder == null) return;
            IdTextBox.Text = _currentOrder.Id.ToString();
            CreatedDateTimePicker.Value = _currentOrder.CreateDate;
            StatusComboBox.SelectedItem = _currentOrder.Status;
            DeliveryAddressControl.Address = _currentOrder.DeliveryAddress;
            AmountValueLabel.Text = _currentOrder.Amount.ToString(CultureInfo.CurrentCulture);
            OrderItemsListBox.Items.Clear();
            foreach (var item in _currentOrder.Items)
            {
                OrderItemsListBox.Items.Add(item);
            }
        }

        private void OrdersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) return;
            var cells = OrdersDataGridView.CurrentRow.Cells;
            var id = int.Parse(cells[0].Value.ToString());
            _currentOrder = GetOrderById(id);
            UpdateFields();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex == -1 || _currentOrder == null) return;
            var status = (OrderStatus) StatusComboBox.SelectedItem;
            _currentOrder.Status = status;
            UpdateOrders();
        }
    }
}