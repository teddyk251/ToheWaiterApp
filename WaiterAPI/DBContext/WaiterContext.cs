using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    var builder = new ConfigurationBuilder().AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);
        //    IConfigurationRoot configuration = builder.Build();
        //    optionsBuilder.UseSqlServer(configuration.GetConnectionString("AndroidWaiterDB"));
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("AndroidWaiterDB");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }



        public DbSet<Element> Elements { get; set; }
        public DbSet<ElementModifier> ElementModifiers { get; set; }
        public DbSet<price> Prices { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<PhysicalTable> PhysicalTables { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherExtensionRestaurant> VoucherExtensionRestaurants { get; set; }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().HasData(
        //    new User
        //    {
        //        Code = "us01",
        //        username = "hab",
        //        password = "h123",
        //        IsActive = true,
        //       // PersonCode = "pe01"

        //    });
        //    modelBuilder.Entity<Person>().HasData(
        //        new Person
        //        {
        //            PersonCode = "pe01",
        //            FirstName = "hannha",
        //            LastName = " ",
        //            DateOFBirth = DateTime.Today,
        //            Gender = "Female",
        //            Type = " ",
        //            Nationality = "Etgiopian",
        //            Active = "true",
        //            Remark = "new",
        //            Group = "waitress",
        //            MiddleName = "M",
        //            Title = "Ms."
        //        });
        //}
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<Category>().HasData(
    //        new Category
    //        {
    //            CategoryID = 1,
    //            CategoryName = "MainDish",
    //        },
    //        new Category
    //        {
    //            CategoryID = 2,
    //            CategoryName = "Drinks",
    //        },
    //        new Category
    //        {
    //            CategoryID = 3,
    //            CategoryName = "Starter",
    //        }
    //        );
    //        modelBuilder.Entity<User>().HasData(
    //        new User
    //        {
    //            username="Alice",
    //            userID=1,
    //            password="123456"
    //        }    
    //        );
    //        modelBuilder.Entity<Item>().HasData(
    //            new Item
    //            {
    //                ItemID=1,
    //                ItemName="Coca Cola",
    //                ItemPrice=12,
    //                CategoryID=2
    //            }
    //            );
    //    }
        }
}
