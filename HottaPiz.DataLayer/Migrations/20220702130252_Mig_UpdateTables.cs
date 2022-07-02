using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_UpdateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToIngredients_CustomPizzas_PizzaId",
                table: "PizzaToIngredients");

            migrationBuilder.DropTable(
                name: "CustomPizzas");

            migrationBuilder.DropTable(
                name: "MainPizzaToIngredients");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Pizzas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCustomPizza",
                table: "Pizzas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7008), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7012), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7016), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7024), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7028), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastModifiedDate",
                value: new DateTime(2022, 7, 2, 17, 32, 52, 114, DateTimeKind.Local).AddTicks(6809));

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_CustomerId",
                table: "Pizzas",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Customer_CustomerId",
                table: "Pizzas",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToIngredients_Pizzas_PizzaId",
                table: "PizzaToIngredients",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Customer_CustomerId",
                table: "Pizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToIngredients_Pizzas_PizzaId",
                table: "PizzaToIngredients");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_CustomerId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "IsCustomPizza",
                table: "Pizzas");

            migrationBuilder.CreateTable(
                name: "CustomPizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PizzaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PizzaTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomPizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomPizzas_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainPizzaToIngredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    PizzaIngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPizzaToIngredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainPizzaToIngredients_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MainPizzaToIngredients_PizzasIngredients_PizzaIngredientId",
                        column: x => x.PizzaIngredientId,
                        principalTable: "PizzasIngredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5023), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5027), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5031), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5035), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5044), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5048), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 17, 22, 18, 95, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_CustomerId",
                table: "CustomPizzas",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MainPizzaToIngredients_PizzaId",
                table: "MainPizzaToIngredients",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_MainPizzaToIngredients_PizzaIngredientId",
                table: "MainPizzaToIngredients",
                column: "PizzaIngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToIngredients_CustomPizzas_PizzaId",
                table: "PizzaToIngredients",
                column: "PizzaId",
                principalTable: "CustomPizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
