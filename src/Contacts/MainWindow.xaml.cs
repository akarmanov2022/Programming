using System;
using System.IO;
using System.Windows;
using Contacts.Models;
using Contacts.ViewModels;

namespace Contacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateMetaFiles();
            DataContext = new MainVm(new Contact());
        }
        
        /// <summary>
        /// Создает мета-данные приложения.
        /// </summary>
        private static void CreateMetaFiles()
        {
            try
            {
                var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var directory = Path.Combine(appDataPath, nameof(Contacts));

                if (Directory.Exists(directory)) return;
                Directory.CreateDirectory(directory);

                var filePath = Path.Combine(directory, "save.json");

                if (File.Exists(filePath)) return;
                File.Create(filePath);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK);
            }
        }
    }
}