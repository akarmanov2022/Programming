using System;
using System.IO;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            CreateFilesToAppData();
            LoadFromAppData();
            
            InitializeComponent();

            CustomersTab.Customers = _store.Customers;
            ItemsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;

            OrdersTab.Customers = _store.Customers;
        }

        private void LoadFromAppData()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var directory = Path.Combine(appDataPath, "ObjectOrientedPractics");
                var filePath = Path.Combine(directory, "save.json");
                _store = Serializer<Store>.FromJson(filePath) ?? new Store();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void SaveToAppData()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var directory = Path.Combine(appDataPath, "ObjectOrientedPractics");
                var filePath = Path.Combine(directory, "save.json");
                Serializer<Store>.ToJson(_store, filePath);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Создает мета-данные приложения в папке AppData.
        /// </summary>
        private static void CreateFilesToAppData()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var directory = Path.Combine(appDataPath, "ObjectOrientedPractics");

                if (Directory.Exists(directory)) return;
                Directory.CreateDirectory(directory);

                var filePath = Path.Combine(directory, "save.json");

                if (File.Exists(filePath)) return;
                File.Create(filePath);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToAppData();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 2:
                    CartsTab.RefreshData();
                    break;
                case 3:
                    OrdersTab.RefreshData();
                    break;
            }
        }
    }
}