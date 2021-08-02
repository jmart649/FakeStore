using FakeStore.Classes;
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
    /// Interaction logic for CustomerHome.xaml
    /// </summary>
    public partial class CustomerHome : Page
    {
        public CustomerHome()
        {
            InitializeComponent();
        }

        private void cShop_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ShopPage());
        }

        private void cCart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CartPage());
        }

        private void cCheckout_Click(object sender, RoutedEventArgs e)
        {
            using var dbContext = new StoreContext();
            var orders = dbContext.Orders.ToList<Order>();
            if (orders.Count == 0)
            {
                this.NavigationService.Navigate(new LoginPage());
            }
            else
            {
                this.NavigationService.Navigate(new CheckoutPage());
            }
        }
    }
}
