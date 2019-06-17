using Microsoft.EntityFrameworkCore.Migrations;

namespace WaiterAPI.Migrations
{
    public partial class SecondMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Code", "IsActive", "PersonCode", "loggedInStatus", "password", "username" },
                values: new object[] { "us01", true, "pe01", 0, "h123", "hab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Code",
                keyValue: "us01");
        }
    }
}
