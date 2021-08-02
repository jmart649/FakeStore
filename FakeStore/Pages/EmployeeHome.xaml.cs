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

namespace FakeStore.Pages
{
    /// <summary>
    /// Interaction logic for EmployeeHome.xaml
    /// </summary>
    public partial class EmployeeHome : Page
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void vInventory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new InventoryPage());
        }

        private void aInventory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddIventory());
        }

        private void dInventory_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DeleteInventory());
        }

        private void eLogout_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new LoginPage());
        }
    }
}
