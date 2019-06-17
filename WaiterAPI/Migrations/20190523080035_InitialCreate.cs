using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WaiterAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupCode = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sequence = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupCode);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonCode = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    DateOFBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonCode);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalTables",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    LocationCode = table.Column<string>(nullable: true),
                    MaxOccupancy = table.Column<int>(nullable: false),
                    RankCode = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalTables", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Vouchers",
                columns: table => new
                {
                    VoucherCode = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    VoucherTo = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    IsIssued = table.Column<bool>(nullable: false),
                    IsVoid = table.Column<bool>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vouchers", x => x.VoucherCode);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    ElementCode = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupCode = table.Column<string>(nullable: true),
                    UOM = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.ElementCode);
                    table.ForeignKey(
                        name: "FK_Elements_Group_GroupCode",
                        column: x => x.GroupCode,
                        principalTable: "Group",
                        principalColumn: "GroupCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    PersonCode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    loggedInStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Users_Persons_PersonCode",
                        column: x => x.PersonCode,
                        principalTable: "Persons",
                        principalColumn: "PersonCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LineItems",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    VoucherCode = table.Column<string>(nullable: true),
                    Element = table.Column<string>(nullable: true),
                    UnitAmount = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    TaxType = table.Column<string>(nullable: true),
                    TaxAmount = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItems", x => x.Code);
                    table.ForeignKey(
                        name: "FK_LineItems_Vouchers_VoucherCode",
                        column: x => x.VoucherCode,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VoucherExtensionRestaurants",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    waiter = table.Column<string>(nullable: true),
                    PhysicalTableCode = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    VoucherCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherExtensionRestaurants", x => x.Code);
                    table.ForeignKey(
                        name: "FK_VoucherExtensionRestaurants_Vouchers_VoucherCode",
                        column: x => x.VoucherCode,
                        principalTable: "Vouchers",
                        principalColumn: "VoucherCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ElementModifiers",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    ElementCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementModifiers", x => x.Code);
                    table.ForeignKey(
                        name: "FK_ElementModifiers_Elements_ElementCode",
                        column: x => x.ElementCode,
                        principalTable: "Elements",
                        principalColumn: "ElementCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    ElementCode = table.Column<string>(nullable: true),
                    Decription = table.Column<string>(nullable: true),
                    PriceValue = table.Column<decimal>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    priority = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Code);
                    table.ForeignKey(
                        name: "FK_Prices_Elements_ElementCode",
                        column: x => x.ElementCode,
                        principalTable: "Elements",
                        principalColumn: "ElementCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementModifiers_ElementCode",
                table: "ElementModifiers",
                column: "ElementCode");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_GroupCode",
                table: "Elements",
                column: "GroupCode");

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_VoucherCode",
                table: "LineItems",
                column: "VoucherCode");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_ElementCode",
                table: "Prices",
                column: "ElementCode");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonCode",
                table: "Users",
                column: "PersonCode");

            migrationBuilder.CreateIndex(
                name: "IX_VoucherExtensionRestaurants_VoucherCode",
                table: "VoucherExtensionRestaurants",
                column: "VoucherCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementModifiers");

            migrationBuilder.DropTable(
                name: "LineItems");

            migrationBuilder.DropTable(
                name: "PhysicalTables");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VoucherExtensionRestaurants");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Vouchers");

            migrationBuilder.DropTable(
                name: "Group");
        }
    }
}
