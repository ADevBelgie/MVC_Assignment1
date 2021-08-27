using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Assignment1.Models;

namespace MVC_Assignment1.Data
{
    public class MVC_Assignment1Context : DbContext
    {
        public MVC_Assignment1Context (DbContextOptions<MVC_Assignment1Context> options)
            : base(options)
        {
           // Database.SetInitializer(new ShirtDBInitializer());
        }

        public DbSet<MVC_Assignment1.Models.ProductTShirtViewModel> ProductTShirtViewModel { get; set; }

        public DbSet<MVC_Assignment1.Models.ShoppingItemViewModel> ShoppingItemViewModel { get; set; }
        public DbSet<MVC_Assignment1.Models.ShoppingBagViewModel> ShoppingBagViewModel { get; set; }
        public DbSet<MVC_Assignment1.Models.CostumerViewModel> CostumerViewModel { get; set; }
        public DbSet<MVC_Assignment1.Models.LoginViewModel> LoginViewModel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostumerViewModel>()
               .HasKey(wd => new { wd.CostumerId, wd.ShoppingBagId });

            //modelBuilder.Entity<CostumerViewModel>()
            //   .HasOne(c => c.ShoppingBag).WithOne(c => c.)

            modelBuilder.Entity<ShoppingBagViewModel>()
               .HasKey(wd => new { wd.ShoppingBagId, wd.CostumerId });

            modelBuilder.Entity<ShoppingItemViewModel>()
               .HasKey(wd => new { wd.ID, wd.productID });

            modelBuilder.Entity<ProductTShirtViewModel>()
               .HasKey(wd => new { wd.ID});

            modelBuilder.Entity<LoginViewModel>()
              .HasKey(wd => new { wd.LoginId });

            //modelBuilder.Entity<ShoppingcartViewModel>()
            //    .HasOne(wd => wd.product)
            //    .WithOne()
            //    .HasForeignKey(wd => wd.productID);

            IList<ProductTShirtViewModel> defaultStandards = new List<ProductTShirtViewModel>();
            for (int i = 1; i < 15; i++)
            {
                defaultStandards.Add(new ProductTShirtViewModel() { ID= i * 5 - 4, Name = "Red Shirt", Price = 502, Picture = "red-shirt.jpg" });
                defaultStandards.Add(new ProductTShirtViewModel() { ID= i * 5 - 3, Name = "Xmas Shirt", Price = 302, Picture = "christmas-shirt.jpg" });
                defaultStandards.Add(new ProductTShirtViewModel() { ID= i * 5 - 2, Name = "King Shirt", Price = 1999, Picture = "king-shirt.jpg" });
                defaultStandards.Add(new ProductTShirtViewModel() { ID= i * 5 - 1, Name = "Tom&Jerry Shirt", Price = 1999, Picture = "Tom-Jerry-shirt.jpg" });
                defaultStandards.Add(new ProductTShirtViewModel() { ID= i * 5, Name = "Plain Shirt", Price = 1999, Picture = "plain-shirt.jpg" });
            }
            modelBuilder.Entity<ProductTShirtViewModel>().HasData(defaultStandards);

            IList<LoginViewModel> defaultUsers = new List<LoginViewModel>();
            defaultUsers.Add(new LoginViewModel() { LoginId = 1, UserName = "admin1", Role = "admin", Password = "admin" });
            defaultUsers.Add(new LoginViewModel() { LoginId = 2, UserName = "arthur", Role = "normal", Password = "arthur" });
            modelBuilder.Entity<LoginViewModel>().HasData(defaultUsers);
        }
    }
}
