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
    /// Interaction logic for InventoryPage.xaml
    /// </summary>
    public partial class InventoryPage : Page
    {
        public InventoryPage()
        {
            InitializeComponent();
            syncDB();
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeeHome());
        }

        private void syncDB()
        {
            using var dbContext = new StoreContext();
            var Listitems = dbContext.Items.ToList<Item>();
            if(Listitems is not null)
            {
                ListItems.ItemsSource = Listitems;
            }
        }
    }
}
