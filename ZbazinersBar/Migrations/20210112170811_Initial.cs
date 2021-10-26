using Microsoft.EntityFrameworkCore.Migrations;

namespace ZbazinersBar.Migrations {
    public partial class Initial : Migration {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Items",
                columns : table => new {
                    ItemID = table.Column<long>(type: "bigint", nullable : false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                        Name = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Description = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Category = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Price = table.Column<decimal>(type: "decimal(8,2)", nullable : false)
                },
                constraints : table => table.PrimaryKey("PK_Items", x => x.ItemID));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns : table => new {
                    OrderID = table.Column<int>(type: "int", nullable : false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                        Name = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Line1 = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Line2 = table.Column<string>(type: "nvarchar(max)", nullable : true),
                        Line3 = table.Column<string>(type: "nvarchar(max)", nullable : true),
                        Zip = table.Column<string>(type: "nvarchar(max)", nullable : true),
                        City = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Country = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        AdditionalGenuineTrdelnik = table.Column<bool>(type: "bit", nullable : false),
                        State = table.Column<string>(type: "nvarchar(max)", nullable : false),
                        Shipped = table.Column<bool>(type: "bit", nullable : false)
                },
                constraints : table => table.PrimaryKey("PK_Orders", x => x.OrderID));

            migrationBuilder.CreateTable(
                name: "CartLine",
                columns : table => new {
                    CartLineID = table.Column<int>(type: "int", nullable : false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                        ItemID = table.Column<long>(type: "bigint", nullable : true),
                        Quantity = table.Column<int>(type: "int", nullable : false),
                        OrderID = table.Column<int>(type: "int", nullable : true)
                },
                constraints : table => {
                    table.PrimaryKey("PK_CartLine", x => x.CartLineID);
                    table.ForeignKey(
                        name: "FK_CartLine_Items_ItemID",
                        column : x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete : ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLine_Orders_OrderID",
                        column : x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete : ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_ItemID",
                table: "CartLine",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CartLine_OrderID",
                table: "CartLine",
                column: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "CartLine");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}