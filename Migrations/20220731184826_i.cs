using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantApi.Migrations
{
    public partial class i : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMastersOrderMasterId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "OrderMastersOrderMasterId",
                table: "OrderDetails",
                newName: "OrderMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderMastersOrderMasterId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderMasterId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMasterId",
                table: "OrderDetails",
                column: "OrderMasterId",
                principalTable: "OrderMasters",
                principalColumn: "OrderMasterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMasters_OrderMasterId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "OrderMasterId",
                table: "OrderDetails",
                newName: "OrderMastersOrderMasterId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderMasterId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderMastersOrderMasterId");

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
