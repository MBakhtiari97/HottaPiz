using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.Context;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.DataLayer.Entities.Pizza;
using HottaPiz.Infrastructure.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HottaPiz.Infrastructure.Services.Implementations
{
    public class PizzaServices : IPizzaServices
    {
        HottaPizContext _context;

        public PizzaServices(HottaPizContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdatePizzaAsync(UpdatePizzaVM pizzaDetails)
        {
            try
            {
                var pizza = GetPizzaById(pizzaDetails.Id);

                pizza.PizzaImageName = pizzaDetails.PizzaImageName;
                pizza.Description = pizzaDetails.Description;
                pizza.PizzaName = pizzaDetails.PizzaName;
                pizza.PizzaTotalPrice = pizzaDetails.PizzaTotalPrice;
                pizza.LastModifiedDate = DateTime.Now;

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Pizza GetPizzaById(int pizzaId)
        {
            return _context.Pizzas.Find(pizzaId);
        }

        public UpdatePizzaVM GetUpdatePizzaVMById(int pizzaId)
        {
            return _context.Pizzas
                .Where(p => p.Id == pizzaId)
                .Select(p => new UpdatePizzaVM()
                {
                    Description = p.Description,
                    Id = p.Id,
                    PizzaImageName = p.PizzaImageName,
                    PizzaName = p.PizzaName,
                    PizzaTotalPrice = p.PizzaTotalPrice

                }).Single();
        }

        public async Task<bool> CreatePizzaAsync(CreatePizzaVM pizzaDetails)
        {
            try
            {
                var newPizza = new Pizza()
                {
                    PizzaImageName = pizzaDetails.PizzaImageName,
                    CreateDate = DateTime.Now,
                    Description = pizzaDetails.Description,
                    PizzaTotalPrice = pizzaDetails.PizzaTotalPrice,
                    PizzaBasePrice = 5,
                    PizzaName = pizzaDetails.PizzaName
                };

                await _context.Pizzas.AddAsync(newPizza);
                await _context.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<PizzaIngredientsVM>> GetPizzasIngredients()
        {
            IQueryable<PizzaIngredientsVM> ingredients = _context.PizzasIngredients
                .Select(pi => new PizzaIngredientsVM()
                {
                    IngredientPrice = pi.IngredientPrice,
                    IngredientId = pi.Id,
                    IngredientName = pi.IngredientTitle
                });
            return await ingredients.ToListAsync();
        }

        public async Task<bool> CreateCustomPizzaIngredients(int pizzaId, List<int> selectedIngredientsIds)
        {
            foreach (var id in selectedIngredientsIds)
            {
                await _context.PizzaToIngredients.AddAsync(new PizzaToIngredients()
                {
                    PizzaId = pizzaId,
                    PizzaIngredientId = id
                });
            }

            return true;
        }
    }
}
