// <auto-generated />
using System;
using MVC_Assignment1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Assignment1.Migrations
{
    [DbContext(typeof(MVC_Assignment1Context))]
    partial class MVC_Assignment1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Assignment1.Models.CostumerViewModel", b =>
                {
                    b.Property<int>("CostumerId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingBagId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShoppingBagCostumerId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingBagId1")
                        .HasColumnType("int");

                    b.HasKey("CostumerId", "ShoppingBagId");

                    b.HasIndex("ShoppingBagId1", "ShoppingBagCostumerId");

                    b.ToTable("CostumerViewModel");
                });

            modelBuilder.Entity("MVC_Assignment1.Models.LoginViewModel", b =>
                {
                    b.Property<int>("LoginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RememberLogin")
                        .HasColumnType("bit");

                    b.Property<string>("ReturnUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginId");

                    b.ToTable("LoginViewModel");

                    b.HasData(
                        new
                        {
                            LoginId = 1,
                            Password = "admin",
                            RememberLogin = false,
                            Role = "admin",
                            UserName = "admin1"
                        },
                        new
                        {
                            LoginId = 2,
                            Password = "arthur",
                            RememberLogin = false,
                            Role = "normal",
                            UserName = "arthur"
                        });
                });

            modelBuilder.Entity("MVC_Assignment1.Models.ProductTShirtViewModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("ProductTShirtViewModel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 2,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 3,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 4,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 5,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 6,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 7,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 8,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 9,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 10,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 11,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 12,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 13,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 14,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 15,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 16,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 17,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 18,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 19,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 20,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 21,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 22,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 23,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 24,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 25,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 26,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 27,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 28,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 29,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 30,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 31,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 32,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 33,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 34,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 35,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 36,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 37,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 38,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 39,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 40,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 41,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 42,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 43,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 44,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 45,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 46,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 47,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 48,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 49,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 50,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 51,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 52,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 53,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 54,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 55,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 56,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 57,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 58,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 59,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 60,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 61,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 62,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 63,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 64,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 65,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 66,
                            Name = "Red Shirt",
                            Picture = "red-shirt.jpg",
                            Price = 502.0
                        },
                        new
                        {
                            ID = 67,
                            Name = "Xmas Shirt",
                            Picture = "christmas-shirt.jpg",
                            Price = 302.0
                        },
                        new
                        {
                            ID = 68,
                            Name = "King Shirt",
                            Picture = "king-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 69,
                            Name = "Tom&Jerry Shirt",
                            Picture = "Tom-Jerry-shirt.jpg",
                            Price = 1999.0
                        },
                        new
                        {
                            ID = 70,
                            Name = "Plain Shirt",
                            Picture = "plain-shirt.jpg",
                            Price = 1999.0
                        });
                });

            modelBuilder.Entity("MVC_Assignment1.Models.ShoppingBagViewModel", b =>
                {
                    b.Property<int>("ShoppingBagId")
                        .HasColumnType("int");

                    b.Property<int>("CostumerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("ShoppingBagId", "CostumerId");

                    b.ToTable("ShoppingBagViewModel");
                });

            modelBuilder.Entity("MVC_Assignment1.Models.ShoppingItemViewModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingBagId")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingBagViewModelCostumerId")
                        .HasColumnType("int");

                    b.Property<int?>("ShoppingBagViewModelShoppingBagId")
                        .HasColumnType("int");

                    b.HasKey("ID", "productID");

                    b.HasIndex("productID");

                    b.HasIndex("ShoppingBagViewModelShoppingBagId", "ShoppingBagViewModelCostumerId");

                    b.ToTable("ShoppingItemViewModel");
                });

            modelBuilder.Entity("MVC_Assignment1.Models.CostumerViewModel", b =>
                {
                    b.HasOne("MVC_Assignment1.Models.ShoppingBagViewModel", "ShoppingBag")
                        .WithMany()
                        .HasForeignKey("ShoppingBagId1", "ShoppingBagCostumerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShoppingBag");
                });

            modelBuilder.Entity("MVC_Assignment1.Models.ShoppingItemViewModel", b =>
                {
                    b.HasOne("MVC_Assignment1.Models.ProductTShirtViewModel", "product")
                        .WithMany()
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Assignment1.Models.ShoppingBagViewModel", null)
                        .WithMany("Items")
                        .HasForeignKey("ShoppingBagViewModelShoppingBagId", "ShoppingBagViewModelCostumerId");

                    b.Navigation("product");
                });

            modelBuilder.Entity("MVC_Assignment1.Models.ShoppingBagViewModel", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
