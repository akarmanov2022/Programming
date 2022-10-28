using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public List<Item> Items { get; set; }
        
        public List<Customer> Customers { get; set; }

        public CartsTab()
        {
            InitializeComponent();
        }
    }
}