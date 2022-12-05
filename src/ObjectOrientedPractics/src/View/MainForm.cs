using System;
using System.IO;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View;

public partial class MainForm : Form
{
    private Store _store;

    public MainForm()
    {
        CreateFilesToAppData();

        InitializeComponent();

        UpdateStore();
    }

    private void UpdateStore()
    {
        _store = StoreService.LoadStore();
        UpdateStoreView();
    }

    private void UpdateStoreView()
    {
        CustomersTab.Customers = _store.Customers;
        ItemsTab.Items = _store.Items;
        CartsTab.Customers = _store.Customers;
        CartsTab.Items = _store.Items;
        PriorityOrderTab.Items = _store.Items;
        OrdersTab.Customers = _store.Customers;
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
        StoreService.SaveStore(_store);
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