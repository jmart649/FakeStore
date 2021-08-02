using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.Classes
{
    public class StoreContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlite(@"Data Source=C:\Users\leek2\source\repos\FakeStore\FakeStore\storeDB.sqlite");
            base.OnConfiguring(opt);
        }
    }

    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string Product_Name { get; set; }
        public int Quantity { get; set; }
        public double Subtotal { get; set; }
    }
}
