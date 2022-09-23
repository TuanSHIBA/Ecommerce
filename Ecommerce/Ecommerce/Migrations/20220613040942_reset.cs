using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Parent",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 511, DateTimeKind.Local).AddTicks(6644), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9646), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9656), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9659), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9662), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9667), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9673), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9676), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9678), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9681), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9685), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9688), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9695), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9696) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Parent",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 3, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8736), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8751), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8754), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8757), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8764), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8767), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8769), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8772), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8773) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8774), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8777), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8779), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8782), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8784), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8787), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8789), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8792), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8794), new DateTime(2022, 5, 23, 13, 32, 21, 4, DateTimeKind.Local).AddTicks(8796) });
        }
    }
}
