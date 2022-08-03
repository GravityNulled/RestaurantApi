using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantApi.Migrations
{
    public partial class fixedtypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMastersOrderMasterId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "OrdeMastersId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "OrderMastersOrderMasterId",
                table: "OrderDetails",
                newName: "OrderMastersId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderMastersOrderMasterId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderMastersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMastersId",
                table: "OrderDetails",
                column: "OrderMastersId",
                principalTable: "OrderMasters",
                principalColumn: "OrderMasterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMastersId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "OrderMastersId",
                table: "OrderDetails",
                newName: "OrderMastersOrderMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderMastersId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderMastersOrderMasterId");

            migrationBuilder.AddColumn<int>(
                name: "OrdeMastersId",
                table: "OrderDetails",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMastersOrderMasterId",
                table: "OrderDetails",
                column: "OrderMastersOrderMasterId",
                principalTable: "OrderMasters",
                principalColumn: "OrderMasterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
