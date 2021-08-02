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
    /// Interaction logic for ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CustomerHome());
        }

        private void PS5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Play Station 5";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach(var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void xbox_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Xbox Series X";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void nintendo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Nintendo Switch";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void blackberry_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Blackberry Phone";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void iphone_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "iPhone 12";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void oneplus_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "OnePlus Phone";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void dell_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Dell Laptop";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void macbook_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "MacBook Pro";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void asus_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "ASUS Laptop";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void macpc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Mac PC";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void dellpc_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Dell PC";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void samsungt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Samsung Tablet";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void ipad_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "iPad Air";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void samsungtv_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Samsung TV";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void sonytv_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Sony TV";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void vizio_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Vizio TV";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void cannon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Cannon Camera";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void nikon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "Nikon Camera";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }

        private void dvdplayer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Added item to Cart");
            int quantity = 1;
            using var dbContext = new StoreContext();
            string name = "DVD Player";
            Item item = dbContext.Items.Where<Item>(b => b.Name == name).First();

            double taxes = item.Price * quantity * (8.25 / 100);

            var orders = dbContext.Orders.ToList<Order>();
            List<string> names = new List<string>();

            foreach (var Names in orders)
            {
                string NAMES = Names.Product_Name;
                names.Add(NAMES);
            }

            if (names.Contains(name))
            {
                Order order = dbContext.Orders.Where<Order>(b => b.Product_Name == name).First();
                double Taxes = item.Price * order.Quantity * (8.25 / 100);
                order.Quantity += 1;
                order.Subtotal = item.Price * order.Quantity + Taxes;
                dbContext.SaveChanges();
            }
            else
            {
                dbContext.Add(new Order { Product_Name = item.Name, Quantity = quantity, Subtotal = item.Price * quantity + taxes });
                dbContext.SaveChanges();
            }
        }
    }
}
