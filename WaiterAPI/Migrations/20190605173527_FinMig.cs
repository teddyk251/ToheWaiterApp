using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaiterAPI.Migrations
{
    public partial class FinMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonCode",
                keyValue: "pe01");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Code",
                keyValue: "us01");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOFBirth",
                table: "Persons",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "LineItems",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOFBirth",
                table: "Persons",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Quantity",
                table: "LineItems",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonCode", "Active", "DateOFBirth", "FirstName", "Gender", "Group", "LastName", "MiddleName", "Nationality", "Remark", "Title", "Type" },
                values: new object[] { "pe01", "true", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "hannha", "Female", "waitress", " ", "M", "Etgiopian", "new", "Ms.", " " });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Code", "IsActive", "PersonCode", "loggedInStatus", "password", "username" },
                values: new object[] { "us01", true, null, 0, "h123", "hab" });
        }
    }
}
