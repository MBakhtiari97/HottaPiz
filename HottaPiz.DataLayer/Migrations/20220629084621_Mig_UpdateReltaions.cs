using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_UpdateReltaions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrdersDetails_PizzaId",
                table: "OrdersDetails",
                column: "PizzaId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Pizzas_PizzaId",
                table: "OrdersDetails",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Pizzas_PizzaId",
                table: "OrdersDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrdersDetails_PizzaId",
                table: "OrdersDetails");
        }
    }
}
