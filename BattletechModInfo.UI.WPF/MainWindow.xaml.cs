using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BattletechModInfo.UI.WPF.ViewModels;
using BattletechModInfo.UI.WPF.Views;

namespace BattletechModInfo.UI.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ViewFiles_Click(object sender, RoutedEventArgs e)
        {
            // Create the FileViewModel instance
            FileViewModel fileViewModel = new FileViewModel();

            // Create and set the DataContext of the FileListView to the FileViewModel
            FileListView fileListView = new FileListView();
            fileListView.DataContext = fileViewModel;

            var window = new Window
            {
                Title = "View Files",
                Content = fileListView,
                Width = 600,
                Height = 400
            };
            window.ShowDialog();
        }
    }
}
