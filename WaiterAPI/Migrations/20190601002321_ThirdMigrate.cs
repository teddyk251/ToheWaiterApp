using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaiterAPI.Migrations
{
    public partial class ThirdMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonCode", "Active", "DateOFBirth", "FirstName", "Gender", "Group", "LastName", "MiddleName", "Nationality", "Remark", "Title", "Type" },
                values: new object[] { "pe01", "true", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), "hannha", "Female", "waitress", " ", "M", "Etgiopian", "new", "Ms.", " " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "PersonCode",
                keyValue: "pe01");
        }
    }
}
