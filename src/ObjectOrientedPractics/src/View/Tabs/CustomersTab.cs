using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private static readonly Color BackColorSuccess = Color.White;

        private static readonly Color BackColorException = Color.LightPink;

        private Customer _currentCustomer;

        private List<Customer> _customers;

        internal List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                UpdateCustomersListBox();
            }
        }

        public CustomersTab()
        {
            InitializeComponent();

            CustomersRemoveButton.Enabled = false;
        }


        private void SelectedCustomerFullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = SelectedCustomerFullnameTextBox.Text;
                if (IsNullOrWhiteSpace(text)) return;
                _currentCustomer.Fullname = text;
                SelectedCustomerFullnameTextBox.BackColor = BackColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                SelectedCustomerFullnameTextBox.BackColor = BackColorException;
            }
        }

        private void CustomersAddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            _currentCustomer.Fullname = $"{nameof(Customer)} {_currentCustomer.Id}";
            Customers.Add(_currentCustomer);
            UpdateCustomersListBox();
            ClearTextBoxes();
        }

        private void CustomersRemoveButton_Click(object sender, EventArgs e)
        {
            Customers.Remove(_currentCustomer);
            UpdateCustomersListBox();
            ClearTextBoxes();
            CustomersRemoveButton.Enabled = false;
            _currentCustomer = new Customer();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer) CustomersListBox.SelectedItem;
            _currentCustomer = selectedCustomer;
            UpdateFields();
            CustomersRemoveButton.Enabled = true;
        }

        private void UpdateFields()
        {
            SelectedCustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            SelectedCustomerFullnameTextBox.Text = _currentCustomer.Fullname;
            DeliveryAddressControl.Address = _currentCustomer.DeliveryAddress;
        }

        private void ClearTextBoxes()
        {
            SelectedCustomerIdTextBox.Clear();
            SelectedCustomerFullnameTextBox.Clear();
            DeliveryAddressControl.Clear();
        }

        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in Customers)
            {
                CustomersListBox.Items.Add(customer);
            }
        }

        private void CustomersRandomButton_Click(object sender, EventArgs e)
        {  
            var random = new Random();
            Customers.Clear();
            Customers.AddRange(CustomerFactory.RandomGenerate(random.Next(10, 100)));
            UpdateCustomersListBox();
        }
    }
}