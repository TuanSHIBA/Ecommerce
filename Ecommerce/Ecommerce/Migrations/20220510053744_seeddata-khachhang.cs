using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class seeddatakhachhang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PassWord",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Active", "Address", "Avatar", "Birthday", "CreateDate", "Email", "FullName", "LastLogin", "PassWord", "Phone", "Salt" },
                values: new object[,]
                {
                    { 1, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 647, DateTimeKind.Local).AddTicks(6129), "Kh1@email.com", "Khách Hàng 1", new DateTime(2022, 5, 10, 12, 37, 43, 648, DateTimeKind.Local).AddTicks(9169), "123", "000000000", null },
                    { 16, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1386), "Kh5@email.com", "Khách Hàng 16", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1387), "123", "000000000", null },
                    { 15, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1383), "Kh5@email.com", "Khách Hàng 15", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1384), "123", "000000000", null },
                    { 14, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1380), "Kh5@email.com", "Khách Hàng 14", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1381), "123", "000000000", null },
                    { 13, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1378), "Kh5@email.com", "Khách Hàng 13", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1379), "123", "000000000", null },
                    { 12, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1375), "Kh5@email.com", "Khách Hàng 12", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1377), "123", "000000000", null },
                    { 11, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1373), "Kh5@email.com", "Khách Hàng 11", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1374), "123", "000000000", null },
                    { 10, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1370), "Kh5@email.com", "Khách Hàng 10", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1371), "123", "000000000", null },
                    { 9, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1368), "Kh5@email.com", "Khách Hàng 9", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1369), "123", "000000000", null },
                    { 8, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1364), "Kh5@email.com", "Khách Hàng 8", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1365), "123", "000000000", null },
                    { 7, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1362), "Kh5@email.com", "Khách Hàng 7", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1363), "123", "000000000", null },
                    { 6, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1355), "Kh5@email.com", "Khách Hàng 6", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1356), "123", "000000000", null },
                    { 5, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1352), "Kh5@email.com", "Khách Hàng 5", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1354), "123", "000000000", null },
                    { 4, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1350), "Kh4@email.com", "Khách Hàng 4", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1351), "123", "000000000", null },
                    { 3, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1347), "Kh3@email.com", "Khách Hàng 3", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1348), "123", "000000000", null },
                    { 2, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1337), "Kh2@email.com", "Khách Hàng 2", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1343), "123", "000000000", null },
                    { 17, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1388), "Kh5@email.com", "Khách Hàng 17", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1389), "123", "000000000", null },
                    { 18, false, "Đồng Nai", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1391), "Kh5@email.com", "Khách Hàng 18", new DateTime(2022, 5, 10, 12, 37, 43, 649, DateTimeKind.Local).AddTicks(1392), "123", "000000000", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18);

            migrationBuilder.AlterColumn<string>(
                name: "PassWord",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
