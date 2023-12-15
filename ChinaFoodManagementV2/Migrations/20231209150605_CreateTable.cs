using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChinaFoodManagementV2.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "tbl_category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_category", x => x.id);
                });

           

            migrationBuilder.CreateTable(
                name: "tbl_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    table_name = table.Column<string>(maxLength: 20, nullable: false),
                    table_status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_food",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    food_name = table.Column<string>(maxLength: 20, nullable: false),
                    food_price = table.Column<long>(type: "bigint", maxLength: 20, nullable: false),
                    category_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_food", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_food_tbl_category_category_id",
                        column: x => x.category_id,
                        principalTable: "tbl_category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "tbl_bill",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_checkin = table.Column<DateTime>(nullable: false),
                    date_checkout = table.Column<DateTime>(nullable: true),
                    status_paid = table.Column<int>(nullable: false),
                    discount = table.Column<int>(nullable: true),
                    total_price = table.Column<long>(type: "bigint", nullable: true),
                    table_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bill", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_bill_tbl_table_table_id",
                        column: x => x.table_id,
                        principalTable: "tbl_table",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "tbl_bill_info",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    food_count = table.Column<int>(nullable: false),
                    bill_id = table.Column<int>(nullable: false),
                    food_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_bill_info", x => x.id);
                    table.ForeignKey(
                        name: "FK_tbl_bill_info_tbl_bill_bill_id",
                        column: x => x.bill_id,
                        principalTable: "tbl_bill",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_tbl_bill_info_tbl_food_food_id",
                        column: x => x.food_id,
                        principalTable: "tbl_food",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_bill_table_id",
                table: "tbl_bill",
                column: "table_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_bill_info_bill_id",
                table: "tbl_bill_info",
                column: "bill_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_bill_info_food_id",
                table: "tbl_bill_info",
                column: "food_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_food_category_id",
                table: "tbl_food",
                column: "category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
                name: "tbl_bill_info");

            
            migrationBuilder.DropTable(
                name: "tbl_bill");

            migrationBuilder.DropTable(
                name: "tbl_food");

            migrationBuilder.DropTable(
                name: "tbl_table");

            migrationBuilder.DropTable(
                name: "tbl_category");
        }
    }
}
