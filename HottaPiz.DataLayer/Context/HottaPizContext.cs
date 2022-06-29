using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Entities.Pizza;
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

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaToIngredients>()
                .HasOne<Pizza>()
                .WithMany()
                .HasForeignKey(g=>g.PizzaId);

            modelBuilder.Entity<PizzaToIngredients>()
                .HasOne<PizzaIngredients>()
                .WithMany()
                .HasForeignKey(g => g.PizzaIngredientId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
