using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WaiterAPI.Models;
namespace WaiterAPI.DBContext
{
    public class WaiterContext: DbContext
    {
        public WaiterContext()
        {

        }
        public WaiterContext(DbContextOptions<WaiterContext> options) : base(options)
        {

        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryID = 1,
                CategoryName = "MainDish",
            },
            new Category
            {
                CategoryID = 2,
                CategoryName = "Drinks",
            },
            new Category
            {
                CategoryID = 3,
                CategoryName = "Starter",
            }
            );
            modelBuilder.Entity<User>().HasData(
            new User
            {
                username="Alice",
                userID=1,
                password="123456"
            }    
            );
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    ItemID=1,
                    ItemName="Coca Cola",
                    ItemPrice=12,
                    CategoryID=2
                }
                );
        }
    }
}
