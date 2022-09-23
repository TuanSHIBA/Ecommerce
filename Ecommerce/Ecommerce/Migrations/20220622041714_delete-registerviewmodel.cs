using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class deleteregisterviewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterViewModel");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 482, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6883), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6895), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6898), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6903), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6906), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6908), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6911), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6913), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6914) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6918), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6921), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6926), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6928), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6931), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 6, 22, 11, 17, 13, 483, DateTimeKind.Local).AddTicks(6934) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterViewModel",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmPassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterViewModel", x => x.CustomerId);
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 346, DateTimeKind.Local).AddTicks(3895), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6844), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6847), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6852), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6916), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6919), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6923), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6925), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 11,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6927), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 12,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 13,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 14,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6935), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 15,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 16,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 17,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6942), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 18,
                columns: new[] { "CreateDate", "LastLogin" },
                values: new object[] { new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6945), new DateTime(2022, 6, 18, 8, 17, 51, 347, DateTimeKind.Local).AddTicks(6946) });
        }
    }
}
