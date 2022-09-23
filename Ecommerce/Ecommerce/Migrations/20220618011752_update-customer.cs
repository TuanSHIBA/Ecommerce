using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class updatecustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "RegisterViewModel",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassWord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterViewModel", x => x.CustomerId);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 346, DateTimeKind.Local).AddTicks(3895), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6844), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6847), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6852), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6919), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6925), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6927), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6935), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6942), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { null, new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6945), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6946) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterViewModel");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 511, DateTimeKind.Local).AddTicks(6644), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9646), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9656), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9659), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9662), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9665), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9667), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9673), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9676), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9678), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9681), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9685), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9688), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "Birthday", "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9695), new DateTime(2022, 6, 13, 11, 9, 41, 512, DateTimeKind.Local).AddTicks(9696) });
        }
    }
}
