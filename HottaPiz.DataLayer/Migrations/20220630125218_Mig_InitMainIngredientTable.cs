using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_InitMainIngredientTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToIngredients_Pizzas_PizzaId",
                table: "PizzaToIngredients");

            migrationBuilder.CreateTable(
                name: "MainPizzaToIngredients",
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
                name: "IX_MainPizzaToIngredients_PizzaId",
                table: "MainPizzaToIngredients",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_MainPizzaToIngredients_PizzaIngredientId",
                table: "MainPizzaToIngredients",
                column: "PizzaIngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainPizzaToIngredients");

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(635), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(642), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(646), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(654), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(658), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(697), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(702), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(706), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(710), new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToIngredients_Pizzas_PizzaId",
                table: "PizzaToIngredients",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
