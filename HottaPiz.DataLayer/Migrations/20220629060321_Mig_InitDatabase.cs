using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PizzaCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PizzaBasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PizzaTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PizzaImageName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PizzasIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IngredientPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzasIngredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PizzaToIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    PizzaIngredientId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaToIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PizzaToIngredients_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaToIngredients_PizzasIngredients_PizzaIngredientId",
                        column: x => x.PizzaIngredientId,
                        principalTable: "PizzasIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaToIngredients_PizzaId",
                table: "PizzaToIngredients",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaToIngredients_PizzaIngredientId",
                table: "PizzaToIngredients",
                column: "PizzaIngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaToIngredients");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "PizzasIngredients");
        }
    }
}
