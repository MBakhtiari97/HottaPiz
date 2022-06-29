using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.DataLayer.Entities.Pizza;
using Microsoft.EntityFrameworkCore;

namespace HottaPiz.DataLayer.ModelBuilderExtension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaIngredients>().HasData(
                new PizzaIngredients { Id = 1, IngredientTitle = "Mushroom", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 2, IngredientTitle = "Beef", IngredientPrice = (decimal)3.99 },
                new PizzaIngredients { Id = 3, IngredientTitle = "Ham", IngredientPrice = (decimal)2.99 },
                new PizzaIngredients { Id = 4, IngredientTitle = "Chicken", IngredientPrice = (decimal)1.99 },
                new PizzaIngredients { Id = 5, IngredientTitle = "Pepperoni", IngredientPrice = (decimal)1.99 },
                new PizzaIngredients { Id = 6, IngredientTitle = "Bologna", IngredientPrice = (decimal)1.99 },
                new PizzaIngredients { Id = 7, IngredientTitle = "CheddarCheese", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 8, IngredientTitle = "GoudaCheese", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 9, IngredientTitle = "Olive", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 10, IngredientTitle = "Pineapple", IngredientPrice = (decimal)6.99 },
                new PizzaIngredients { Id = 11, IngredientTitle = "Tomato", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 12, IngredientTitle = "Onion", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 13, IngredientTitle = "Potato", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 14, IngredientTitle = "SweatPepper", IngredientPrice = (decimal)0.49 },
                new PizzaIngredients { Id = 15, IngredientTitle = "Vegetable", IngredientPrice = (decimal)0.99 },
                new PizzaIngredients { Id = 16, IngredientTitle = "TomatoSauce", IngredientPrice = (decimal)0 },
                new PizzaIngredients { Id = 17, IngredientTitle = "FrenchSauce", IngredientPrice = (decimal)0 },
                new PizzaIngredients { Id = 18, IngredientTitle = "MayonnaiseSauce", IngredientPrice = (decimal)0 }
               );

            modelBuilder.Entity<Pizza>().HasData(
                new Pizza { Id = 1, PizzaBasePrice = 5, PizzaImageName = "Veggie Pizza.png", PizzaName = "Veggie Pizza" },
                new Pizza { Id = 2, PizzaBasePrice = 5, PizzaImageName = "Pepperoni Pizza.png", PizzaName = "Pepperoni Pizza" },
                new Pizza { Id = 3, PizzaBasePrice = 5, PizzaImageName = "Cheese Pizza.png", PizzaName = "Cheese Pizza" },
                new Pizza { Id = 4, PizzaBasePrice = 5, PizzaImageName = "Meats Pizza.png", PizzaName = "Meats Pizza" },
                new Pizza { Id = 5, PizzaBasePrice = 5, PizzaImageName = "Margherita Pizza.png", PizzaName = "Margherita Pizza" },
                new Pizza { Id = 6, PizzaBasePrice = 5, PizzaImageName = "BBQ Chicken Pizza.png", PizzaName = "BBQ Chicken Pizza" },
                new Pizza { Id = 7, PizzaBasePrice = 5, PizzaImageName = "Hawaiian Pizza.png", PizzaName = "Hawaiian Pizza" },
                new Pizza { Id = 8, PizzaBasePrice = 5, PizzaImageName = "Buffalo Pizza.png", PizzaName = "Buffalo Pizza" },
                new Pizza { Id = 9, PizzaBasePrice = 5, PizzaImageName = "Supreme Pizza.png", PizzaName = "Supreme Pizza" },
                new Pizza { Id = 10, PizzaBasePrice = 5, PizzaImageName = "The Works Pizza.png", PizzaName = "The Works Pizza" }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, CustomerEmailAddress = "admin@admin.com", CustomerFirstName = "admin", CustomerLastName = "admin", CustomerPhoneNumber = "01185966985", IsAdmin = true, CustomerFirstAddress = "US , NY , Times Square , 187 Ave , No.33" }
            );
        }
    }
}
