using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Customer;
using HottaPiz.DataLayer.Entities.Order;
using HottaPiz.DataLayer.Entities.Pizza;
using HottaPiz.DataLayer.ModelBuilderExtension;
using Microsoft.EntityFrameworkCore;

namespace HottaPiz.DataLayer.Context
{
    public class HottaPizContext:DbContext
    {
        public HottaPizContext(DbContextOptions<HottaPizContext> options):base(options)
        {
            
        }

        #region DB_Sets

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaIngredients> PizzasIngredients { get; set; }
        public DbSet<PizzaToIngredients> PizzaToIngredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
        public DbSet<Customer> Customer { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Relations

            modelBuilder.Entity<PizzaToIngredients>()
                .HasOne<Pizza>()
                .WithMany()
                .HasForeignKey(g => g.PizzaId);

            modelBuilder.Entity<PizzaToIngredients>()
                .HasOne<PizzaIngredients>()
                .WithMany()
                .HasForeignKey(g => g.PizzaIngredientId);

            modelBuilder.Entity<OrderDetails>()
                .HasOne<Order>()
                .WithMany()
                .HasForeignKey(o => o.OrderId);

            modelBuilder.Entity<Order>()
                .HasOne<Customer>()
                .WithMany()
                .HasForeignKey(o => o.CustomerId);

            modelBuilder.Entity<OrderDetails>()
                .HasOne<Pizza>()
                .WithMany()
                .HasForeignKey(o => o.PizzaId);

            #endregion

            #region Query Filters

            modelBuilder.Entity<Customer>()
                .HasQueryFilter(c => !c.IsDelete);
            modelBuilder.Entity<Pizza>()
                .HasQueryFilter(p => !p.IsDelete);
            modelBuilder.Entity<Order>()
                .HasQueryFilter(o => !o.IsDelete);
            modelBuilder.Entity<OrderDetails>()
                .HasQueryFilter(od => !od.IsDelete);
            modelBuilder.Entity<PizzaIngredients>()
                .HasQueryFilter(pi => !pi.IsDelete);
            modelBuilder.Entity<PizzaToIngredients>()
                .HasQueryFilter(pti => !pti.IsDelete);

            #endregion

            #region Seed Data

            modelBuilder.Seed();

            #endregion


            base.OnModelCreating(modelBuilder);
        }
    }
}
