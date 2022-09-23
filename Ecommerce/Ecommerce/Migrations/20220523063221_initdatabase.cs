using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Levels = table.Column<int>(type: "int", nullable: false),
                    Ordering = table.Column<int>(type: "int", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CateID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "TransactSatatus",
                columns: table => new
                {
                    TransactSatatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactSatatus", x => x.TransactSatatusID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BestSellers = table.Column<bool>(type: "bit", nullable: false),
                    HomeFlag = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitsInStock = table.Column<int>(type: "int", nullable: false),
                    CateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CateId",
                        column: x => x.CateId,
                        principalTable: "Categories",
                        principalColumn: "CateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AcccountID = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AcccountID);
                    table.ForeignKey(
                        name: "FK_Accounts_Roles_AcccountID",
                        column: x => x.AcccountID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    Paid = table.Column<bool>(type: "bit", nullable: false),
                    PaidPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMoney = table.Column<double>(type: "float", nullable: false),
                    PaymentID = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true),
                    TransactSatatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_TransactSatatus_TransactSatatusID",
                        column: x => x.TransactSatatusID,
                        principalTable: "TransactSatatus",
                        principalColumn: "TransactSatatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailID = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    TotalMoney = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderDetailID",
                        column: x => x.OrderDetailID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CateID", "Alias", "CateName", "Cover", "Description", "Levels", "MetaDesc", "MetaKey", "Ordering", "Parent", "Published", "Thumb", "Title" },
                values: new object[,]
                {
                    { 1, null, "Rau Củ", null, "Rau Củ", 0, null, null, 0, null, true, null, null },
                    { 2, null, "Trái Cây", null, "Trái Cây", 0, null, null, 0, null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Active", "Address", "Avatar", "Birthday", "CreateDate", "Email", "FullName", "LastLogin", "PassWord", "Phone", "Salt" },
                values: new object[,]
                {
                    { 18, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8794), "Kh5@email.com", "Khách Hàng 18", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8796), "123", "000000000", null },
                    { 17, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8792), "Kh5@email.com", "Khách Hàng 17", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8793), "123", "000000000", null },
                    { 16, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8789), "Kh5@email.com", "Khách Hàng 16", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8791), "123", "000000000", null },
                    { 15, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8787), "Kh5@email.com", "Khách Hàng 15", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8788), "123", "000000000", null },
                    { 14, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8784), "Kh5@email.com", "Khách Hàng 14", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8785), "123", "000000000", null },
                    { 13, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8782), "Kh5@email.com", "Khách Hàng 13", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8783), "123", "000000000", null },
                    { 12, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8779), "Kh5@email.com", "Khách Hàng 12", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8780), "123", "000000000", null },
                    { 11, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8777), "Kh5@email.com", "Khách Hàng 11", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8778), "123", "000000000", null },
                    { 10, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8774), "Kh5@email.com", "Khách Hàng 10", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8775), "123", "000000000", null },
                    { 9, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8772), "Kh5@email.com", "Khách Hàng 9", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8773), "123", "000000000", null },
                    { 8, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8769), "Kh5@email.com", "Khách Hàng 8", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8770), "123", "000000000", null },
                    { 7, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8767), "Kh5@email.com", "Khách Hàng 7", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8768), "123", "000000000", null },
                    { 6, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8764), "Kh5@email.com", "Khách Hàng 6", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8765), "123", "000000000", null },
                    { 5, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8757), "Kh5@email.com", "Khách Hàng 5", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8760), "123", "000000000", null },
                    { 4, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8754), "Kh4@email.com", "Khách Hàng 4", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8755), "123", "000000000", null },
                    { 3, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8751), "Kh3@email.com", "Khách Hàng 3", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8752), "123", "000000000", null },
                    { 2, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8736), "Kh2@email.com", "Khách Hàng 2", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8747), "123", "000000000", null },
                    { 1, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 23, 13, 32, 21, 3, DateTimeKind.Local).AddTicks(5264), "Kh1@email.com", "Khách Hàng 1", new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(6154), "123", "000000000", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "Administrator", "Admin" },
                    { 2, "Nhân Viên", "Staff" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Active", "Alias", "BestSellers", "CateId", "DateCreated", "DateModified", "Description", "Discount", "HomeFlag", "MetaDesc", "MetaKey", "Price", "ProductName", "ShortDescription", "Tags", "Thumb", "Title", "UnitsInStock", "Video" },
                values: new object[,]
                {
                    { 1, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Khoai Lang", null, null, null, null, 10, null },
                    { 2, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Rau Muống", null, null, null, null, 10, null },
                    { 3, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Chanh Dây", null, null, null, null, 10, null },
                    { 4, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Bí Đỏ", null, null, null, null, 10, null },
                    { 5, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Cà Rốt", null, null, null, null, 10, null },
                    { 6, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Cà Chua", null, null, null, null, 10, null },
                    { 7, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Dưa Leo", null, null, null, null, 10, null },
                    { 8, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Bắp Mỹ", null, null, null, null, 10, null },
                    { 9, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Hành Lá", null, null, null, null, 10, null },
                    { 10, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, false, null, null, 30000, "Su Su", null, null, null, null, 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TransactSatatusID",
                table: "Orders",
                column: "TransactSatatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CateId",
                table: "Products",
                column: "CateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "TransactSatatus");
        }
    }
}
