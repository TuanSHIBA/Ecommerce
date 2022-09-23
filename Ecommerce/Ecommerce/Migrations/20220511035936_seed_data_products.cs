using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class seed_data_products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_ProductID",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 287, DateTimeKind.Local).AddTicks(338), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4323), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4326), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4328), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4333), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4336), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4338), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4341), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4343), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4346), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4348), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4352), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4355), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4357), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4358) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 5, 11, 10, 59, 36, 288, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Active", "Alias", "BestSellers", "CateId", "DateCreated", "DateModified", "Discount", "HomeFlag", "MetaDesc", "MetaKey", "Price", "ProductName", "ShortDDescriptionesc", "Tags", "Thumb", "Title", "UnitsInStock", "Video" },
                values: new object[,]
                {
                    { 9, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Hành Lá", null, null, null, null, 10, null },
                    { 8, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Bắp Mỹ", null, null, null, null, 10, null },
                    { 7, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Dưa Leo", null, null, null, null, 10, null },
                    { 6, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Cà Chua", null, null, null, null, 10, null },
                    { 5, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Cà Rốt", null, null, null, null, 10, null },
                    { 4, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Bí Đỏ", null, null, null, null, 10, null },
                    { 3, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Chanh Dây", null, null, null, null, 10, null },
                    { 10, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Su Su", null, null, null, null, 10, null },
                    { 2, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Rau Muống", null, null, null, null, 10, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CateId",
                table: "Products",
                column: "CateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CateId",
                table: "Products",
                column: "CateId",
                principalTable: "Categories",
                principalColumn: "CateID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CateId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CateId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10);

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 515, DateTimeKind.Local).AddTicks(2036), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6535), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6538), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6545), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6548), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6551), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6554), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6556), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6559), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6561), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6562) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6564), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6566), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6569), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6572), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6574), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6577), new DateTime(2022, 5, 11, 10, 31, 29, 516, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_ProductID",
                table: "Products",
                column: "ProductID",
                principalTable: "Categories",
                principalColumn: "CateID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
