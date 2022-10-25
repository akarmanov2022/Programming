using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        private readonly Store _store;
        public MainForm()
        {
            _store = new Store();
            InitializeComponent();
            
            CustomersTab.Customers = _store.Customers;
            ItemsTab.Items = _store.Items;
        }
    }
}