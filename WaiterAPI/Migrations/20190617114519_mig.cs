using Microsoft.EntityFrameworkCore.Migrations;

namespace WaiterAPI.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "VoucherExtensionRestaurants",
                newName: "VECode");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Prices",
                newName: "PriceCode");

            migrationBuilder.RenameColumn(
                name: "Element",
                table: "LineItems",
                newName: "VEcode");

            migrationBuilder.AlterColumn<string>(
                name: "VEcode",
                table: "LineItems",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ElementCode",
                table: "LineItems",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_ElementCode",
                table: "LineItems",
                column: "ElementCode");

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_VEcode",
                table: "LineItems",
                column: "VEcode");

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_Elements_ElementCode",
                table: "LineItems",
                column: "ElementCode",
                principalTable: "Elements",
                principalColumn: "ElementCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LineItems_VoucherExtensionRestaurants_VEcode",
                table: "LineItems",
                column: "VEcode",
                principalTable: "VoucherExtensionRestaurants",
                principalColumn: "VECode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_Elements_ElementCode",
                table: "LineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_LineItems_VoucherExtensionRestaurants_VEcode",
                table: "LineItems");

            migrationBuilder.DropIndex(
                name: "IX_LineItems_ElementCode",
                table: "LineItems");

            migrationBuilder.DropIndex(
                name: "IX_LineItems_VEcode",
                table: "LineItems");

            migrationBuilder.DropColumn(
                name: "ElementCode",
                table: "LineItems");

            migrationBuilder.RenameColumn(
                name: "VECode",
                table: "VoucherExtensionRestaurants",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "PriceCode",
                table: "Prices",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "VEcode",
                table: "LineItems",
                newName: "Element");

            migrationBuilder.AlterColumn<string>(
                name: "Element",
                table: "LineItems",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
