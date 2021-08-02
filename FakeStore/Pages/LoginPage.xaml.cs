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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void customer_Button_Click(object sender, RoutedEventArgs e)
        {

            if (cUsername.Text is not "")
            {
                this.NavigationService.Navigate(new CustomerHome());
            }
            else
            {
                MessageBox.Show("Invalid");
            }

        }

        private void employee_Button_Click(object sender, RoutedEventArgs e)
        {
            if (eUsername.Text == "jmart649")
            {
                this.NavigationService.Navigate(new EmployeeHome());
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
