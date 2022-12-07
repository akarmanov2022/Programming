using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs;

public partial class OrdersTab : UserControl
{
        
    private List<Customer> _customers;

    private List<Order> Orders { set; get; } = new List<Order>();

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
    }

    public void RefreshData()
    {
        UpdateOrders();
    }

    public void UpdateOrders()
    {
        if (_customers == null) return;
        OrdersDataGridView.Rows.Clear();
        Orders.Clear();
        OrderControl.Clear();

        foreach (var customer in _customers)
        {
            foreach (var order in customer.Orders)
            {
                Orders.Add(order);
                OrdersDataGridView.Rows.Add(
                    new DataGridViewRow
                    {
                        Cells =
                        {
                            new DataGridViewTextBoxCell { Value = order.Id },
                            new DataGridViewTextBoxCell { Value = order.CreateDate },
                            new DataGridViewTextBoxCell { Value = order.History.Keys.Last() },
                            new DataGridViewTextBoxCell { Value = order.Status },
                            new DataGridViewTextBoxCell { Value = customer.Fullname },
                            new DataGridViewTextBoxCell { Value = order.DeliveryAddress.ToString() },
                            new DataGridViewTextBoxCell { Value = order.Amount },
                            new DataGridViewTextBoxCell { Value = order.TotalAmount }
                        }
                    });
            }
        }

        if (OrdersDataGridView.Rows.Count <= 1 || OrdersDataGridView.CurrentRow == null) return;
        var currentRowIndex = OrdersDataGridView.CurrentRow.Index;
        OrdersDataGridView.Rows[currentRowIndex].Selected = true;
    }

    private Order GetOrderById(int id)
    {
        var orderById = Orders.Find(order => id.Equals(order.Id));
        return orderById;
    }

    private void OrdersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (OrdersDataGridView.CurrentRow == null) return;
        var cells = OrdersDataGridView.CurrentRow.Cells;
        var id = int.Parse(cells[0].Value.ToString());
        OrderControl.Order = GetOrderById(id);
    }
}