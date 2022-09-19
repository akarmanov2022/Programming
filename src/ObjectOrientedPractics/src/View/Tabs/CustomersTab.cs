using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using static System.String;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private static readonly Color BackColorSuccess = Color.White;

        private static readonly Color BackColorException = Color.LightPink;

        private readonly List<Customer> _customers = new List<Customer>();

        private Customer _currentCustomer = new Customer();
        
        public CustomersTab()
        {
            InitializeComponent();

            CustomersAddButton.Enabled = false;
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
            EnableAddButton();
        }

        private void SelectedCustomerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var text = SelectedCustomerAddressTextBox.Text;
                if (IsNullOrWhiteSpace(text)) return;
                _currentCustomer.Address = text;
                SelectedCustomerAddressTextBox.BackColor = BackColorSuccess;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                SelectedCustomerAddressTextBox.BackColor = BackColorException;
            }
            EnableAddButton();
        }

        private void CustomersAddButton_Click(object sender, EventArgs e)
        {
            _customers.Add(_currentCustomer);
            _currentCustomer = new Customer();
            UpdateCustomersListBox();
            ClearTextBoxes();
            EnableAddButton();
        }

        private void CustomersRemoveButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            UpdateCustomersListBox();
            ClearTextBoxes();
            CustomersRemoveButton.Enabled = false;
            _currentCustomer = new Customer();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCustomer = (Customer) CustomersListBox.SelectedItem;
            _currentCustomer = selectedCustomer;
            UpdateValueInTextBoxes();
            CustomersRemoveButton.Enabled = true;
        }

        private void UpdateValueInTextBoxes()
        {
            SelectedCustomerIdTextBox.Text = _currentCustomer.Id.ToString();
            SelectedCustomerAddressTextBox.Text = _currentCustomer.Address;
            SelectedCustomerFullnameTextBox.Text = _currentCustomer.Fullname;
        }

        private void ClearTextBoxes()
        {
            SelectedCustomerIdTextBox.Clear();
            SelectedCustomerFullnameTextBox.Clear();
            SelectedCustomerAddressTextBox.Clear();
        }

        private void EnableAddButton()
        {
            CustomersAddButton.Enabled = IsNullOrEmpty(SelectedCustomerIdTextBox.Text) 
                                     && !IsNullOrWhiteSpace(_currentCustomer.Fullname) 
                                     && !IsNullOrWhiteSpace(_currentCustomer.Address);
        }

        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add(customer);
            }
        }
    }
}