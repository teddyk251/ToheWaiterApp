using Microsoft.EntityFrameworkCore.Migrations;

namespace WaiterAPI.Migrations
{
    public partial class FinalMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Code",
                keyValue: "us01",
                column: "PersonCode",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Code",
                keyValue: "us01",
                column: "PersonCode",
                value: "pe01");
        }
    }
}
