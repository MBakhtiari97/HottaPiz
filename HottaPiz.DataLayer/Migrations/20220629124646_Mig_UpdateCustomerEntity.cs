using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_UpdateCustomerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5969), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5976), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5980), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5984), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5988), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5993), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5997), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6005), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6008), new DateTime(2022, 6, 29, 17, 16, 46, 142, DateTimeKind.Local).AddTicks(6010) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerEmailAddress", "CustomerFirstAddress", "CustomerFirstName", "CustomerLastName", "CustomerPhoneNumber", "CustomerRegisterDate", "CustomerSecondAddress", "IsAdmin", "IsDelete", "LastModifiedDate" },
                values: new object[] { 1, "admin@admin.com", "US , NY , Times Square , 187 Ave , No.33", "admin", "admin", "01185966985", new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(9008), null, true, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8957), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8961), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8965), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8969), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8973), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8977), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8981), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8985), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateDate", "LastModifiedDate" },
                values: new object[] { new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8989), new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 17,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 18,
                column: "LastModifiedDate",
                value: new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8823));
        }
    }
}
