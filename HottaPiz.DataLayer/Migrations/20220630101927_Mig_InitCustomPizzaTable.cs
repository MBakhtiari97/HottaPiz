using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_InitCustomPizzaTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaCode",
                table: "Pizzas");

            migrationBuilder.CreateTable(
                name: "CustomPizzas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PizzaTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(635), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(642), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(646), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(650), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(654), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(658), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(697), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(702), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(706), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(710), "", new DateTime(2022, 6, 30, 14, 49, 26, 546, DateTimeKind.Local).AddTicks(712) });

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

            migrationBuilder.CreateIndex(
                name: "IX_CustomPizzas_CustomerId",
                table: "CustomPizzas",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToIngredients_CustomPizzas_PizzaId",
                table: "PizzaToIngredients",
                column: "PizzaId",
                principalTable: "CustomPizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToIngredients_CustomPizzas_PizzaId",
                table: "PizzaToIngredients");

            migrationBuilder.DropTable(
                name: "CustomPizzas");

            migrationBuilder.AddColumn<string>(
                name: "PizzaCode",
                table: "Pizzas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5969), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5976), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5980), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5984), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5988), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5993), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5997), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6000), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6005), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "Description", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6008), null, new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5748));
        }
    }
}
