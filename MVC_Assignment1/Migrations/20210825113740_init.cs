using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Assignment1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginViewModel",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RememberLogin = table.Column<bool>(type: "bit", nullable: false),
                    ReturnUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginViewModel", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "ProductTShirtViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTShirtViewModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingBagViewModel",
                columns: table => new
                {
                    ShoppingBagId = table.Column<int>(type: "int", nullable: false),
                    CostumerId = table.Column<int>(type: "int", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingBagViewModel", x => new { x.ShoppingBagId, x.CostumerId });
                });

            migrationBuilder.CreateTable(
                name: "CostumerViewModel",
                columns: table => new
                {
                    CostumerId = table.Column<int>(type: "int", nullable: false),
                    ShoppingBagId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoppingBagId1 = table.Column<int>(type: "int", nullable: false),
                    ShoppingBagCostumerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostumerViewModel", x => new { x.CostumerId, x.ShoppingBagId });
                    table.ForeignKey(
                        name: "FK_CostumerViewModel_ShoppingBagViewModel_ShoppingBagId1_ShoppingBagCostumerId",
                        columns: x => new { x.ShoppingBagId1, x.ShoppingBagCostumerId },
                        principalTable: "ShoppingBagViewModel",
                        principalColumns: new[] { "ShoppingBagId", "CostumerId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingItemViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productID = table.Column<int>(type: "int", nullable: false),
                    ShoppingBagId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingBagViewModelCostumerId = table.Column<int>(type: "int", nullable: true),
                    ShoppingBagViewModelShoppingBagId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingItemViewModel", x => new { x.ID, x.productID });
                    table.ForeignKey(
                        name: "FK_ShoppingItemViewModel_ProductTShirtViewModel_productID",
                        column: x => x.productID,
                        principalTable: "ProductTShirtViewModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShoppingItemViewModel_ShoppingBagViewModel_ShoppingBagViewModelShoppingBagId_ShoppingBagViewModelCostumerId",
                        columns: x => new { x.ShoppingBagViewModelShoppingBagId, x.ShoppingBagViewModelCostumerId },
                        principalTable: "ShoppingBagViewModel",
                        principalColumns: new[] { "ShoppingBagId", "CostumerId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LoginViewModel",
                columns: new[] { "LoginId", "Password", "RememberLogin", "ReturnUrl", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "admin", false, null, "admin", "admin1" },
                    { 2, "arthur", false, null, "normal", "arthur" }
                });

            migrationBuilder.InsertData(
                table: "ProductTShirtViewModel",
                columns: new[] { "ID", "Name", "Picture", "Price" },
                values: new object[,]
                {
                    { 50, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 49, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 48, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 47, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 46, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 45, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 44, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 43, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 42, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 41, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 40, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 39, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 38, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 37, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 51, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 52, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 53, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 54, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 68, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 67, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 66, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 65, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 64, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 63, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 36, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 62, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 60, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 59, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 58, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 57, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 56, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 55, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 61, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 35, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 34, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 33, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 14, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 13, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 12, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 11, "Red Shirt", "red-shirt.jpg", 502.0 }
                });

            migrationBuilder.InsertData(
                table: "ProductTShirtViewModel",
                columns: new[] { "ID", "Name", "Picture", "Price" },
                values: new object[,]
                {
                    { 10, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 9, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 15, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 8, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 6, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 5, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 4, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 3, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 2, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 1, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 7, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 69, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 16, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 18, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 32, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 31, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 30, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 29, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 28, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 27, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 17, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 26, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 24, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 23, "King Shirt", "king-shirt.jpg", 1999.0 },
                    { 22, "Xmas Shirt", "christmas-shirt.jpg", 302.0 },
                    { 21, "Red Shirt", "red-shirt.jpg", 502.0 },
                    { 20, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 19, "Tom&Jerry Shirt", "Tom-Jerry-shirt.jpg", 1999.0 },
                    { 25, "Plain Shirt", "plain-shirt.jpg", 1999.0 },
                    { 70, "Plain Shirt", "plain-shirt.jpg", 1999.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostumerViewModel_ShoppingBagId1_ShoppingBagCostumerId",
                table: "CostumerViewModel",
                columns: new[] { "ShoppingBagId1", "ShoppingBagCostumerId" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItemViewModel_productID",
                table: "ShoppingItemViewModel",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingItemViewModel_ShoppingBagViewModelShoppingBagId_ShoppingBagViewModelCostumerId",
                table: "ShoppingItemViewModel",
                columns: new[] { "ShoppingBagViewModelShoppingBagId", "ShoppingBagViewModelCostumerId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostumerViewModel");

            migrationBuilder.DropTable(
                name: "LoginViewModel");

            migrationBuilder.DropTable(
                name: "ShoppingItemViewModel");

            migrationBuilder.DropTable(
                name: "ProductTShirtViewModel");

            migrationBuilder.DropTable(
                name: "ShoppingBagViewModel");
        }
    }
}
