using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class seeddataproducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CateId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CateID", "Alias", "CateName", "Cover", "Description", "Levels", "MetaDesc", "MetaKey", "Ordering", "Parent", "Published", "Thumb", "Title" },
                values: new object[,]
                {
                    { 1, null, "Rau Củ", null, "Rau Củ", 0, null, null, 0, null, true, null, null },
                    { 2, null, "Trái Cây", null, "Trái Cây", 0, null, null, 0, null, true, null, null }
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "Active", "Alias", "BestSellers", "CateId", "DateCreated", "DateModified", "Discount", "HomeFlag", "MetaDesc", "MetaKey", "Price", "ProductName", "ShortDDescriptionesc", "Tags", "Thumb", "Title", "UnitsInStock", "Video" },
                values: new object[] { 1, true, null, false, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, null, null, 30000, "Khoai Lang", null, null, null, null, 10, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CateID",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CateId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 647, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 5, 10, 12, 37, 43, 648, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1337), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1347), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1348) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1350), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1352), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1355), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1362), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1364), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1368), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1370), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1373), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1378), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1383), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1386), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1388), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1391), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1392) });
        }
    }
}
