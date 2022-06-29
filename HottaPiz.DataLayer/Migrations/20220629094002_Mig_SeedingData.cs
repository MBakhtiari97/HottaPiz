using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HottaPiz.DataLayer.Migrations
{
    public partial class Mig_SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerSubscriptionNumber",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CustomerEmailAddress", "CustomerFirstAddress", "CustomerFirstName", "CustomerLastName", "CustomerPhoneNumber", "CustomerRegisterDate", "CustomerSecondAddress", "IsAdmin", "IsDelete", "LastModifiedDate" },
                values: new object[] { 1, "admin@admin.com", "US , NY , Times Square , 187 Ave , No.33", "admin", "admin", "01185966985", new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(9008), null, true, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "CreateDate", "Description", "IsDelete", "LastModifiedDate", "PizzaBasePrice", "PizzaCode", "PizzaImageName", "PizzaName", "PizzaTotalPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8950), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8952), 5m, null, "Veggie Pizza.png", "Veggie Pizza", 0m },
                    { 2, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8957), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8958), 5m, null, "Pepperoni Pizza.png", "Pepperoni Pizza", 0m },
                    { 3, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8961), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8962), 5m, null, "Cheese Pizza.png", "Cheese Pizza", 0m },
                    { 4, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8965), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8966), 5m, null, "Meats Pizza.png", "Meats Pizza", 0m },
                    { 5, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8969), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8970), 5m, null, "Margherita Pizza.png", "Margherita Pizza", 0m },
                    { 6, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8973), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8974), 5m, null, "BBQ Chicken Pizza.png", "BBQ Chicken Pizza", 0m },
                    { 7, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8977), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8978), 5m, null, "Hawaiian Pizza.png", "Hawaiian Pizza", 0m },
                    { 8, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8981), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8982), 5m, null, "Buffalo Pizza.png", "Buffalo Pizza", 0m },
                    { 9, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8985), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8986), 5m, null, "Supreme Pizza.png", "Supreme Pizza", 0m },
                    { 10, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8989), null, false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8990), 5m, null, "The Works Pizza.png", "The Works Pizza", 0m }
                });

            migrationBuilder.InsertData(
                table: "PizzasIngredients",
                columns: new[] { "Id", "IngredientPrice", "IngredientTitle", "IsDelete", "LastModifiedDate" },
                values: new object[,]
                {
                    { 1, 0.49m, "Mushroom", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8750) },
                    { 2, 3.99m, "Beef", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8784) },
                    { 3, 2.99m, "Ham", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8787) },
                    { 4, 1.99m, "Chicken", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8789) },
                    { 5, 1.99m, "Pepperoni", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8792) },
                    { 6, 1.99m, "Bologna", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8794) },
                    { 7, 0.49m, "CheddarCheese", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8797) },
                    { 8, 0.49m, "GoudaCheese", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8799) },
                    { 9, 0.49m, "Olive", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8802) },
                    { 10, 6.99m, "Pineapple", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8804) },
                    { 11, 0.49m, "Tomato", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8807) },
                    { 12, 0.49m, "Onion", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8809) },
                    { 13, 0.49m, "Potato", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8811) },
                    { 14, 0.49m, "SweatPepper", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8814) },
                    { 15, 0.99m, "Vegetable", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8816) },
                    { 16, 0m, "TomatoSauce", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8819) },
                    { 17, 0m, "FrenchSauce", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8821) },
                    { 18, 0m, "MayonnaiseSauce", false, new DateTime(2022, 6, 29, 14, 10, 1, 890, DateTimeKind.Local).AddTicks(8823) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PizzasIngredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "CustomerSubscriptionNumber",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
