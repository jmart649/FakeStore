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
    /// Interaction logic for AddIventory.xaml
    /// </summary>
    public partial class AddIventory : Page
    {
        public AddIventory()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EmployeeHome());
        }

        private void addInv_Click(object sender, RoutedEventArgs e)
        {
            if(item.Text is not "" & price.Text is not "")
            {
                double price1 = double.Parse(price.Text);
                using var dbContext = new StoreContext();
                dbContext.Items.Add(new() { Name = item.Text, Price = price1 });
                dbContext.SaveChanges();
                item.Clear();
                price.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Entry");
            }
        }
    }
}
