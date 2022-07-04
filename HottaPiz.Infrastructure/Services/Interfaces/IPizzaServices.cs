using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HottaPiz.DataLayer.DTOs.Pizza;
using HottaPiz.DataLayer.Entities.Pizza;

namespace HottaPiz.Infrastructure.Services.Interfaces
{
    public interface IPizzaServices
    {
        public Task<List<Pizza>> GetAllPizzasAsync();
        public Task<bool> UpdatePizzaAsync(UpdatePizzaVM pizzaDetails);
        public UpdatePizzaVM GetUpdatePizzaVMById(int pizzaId);
        public Task<bool> CreatePizzaAsync(CreatePizzaVM pizzaDetails);
        public Task<List<PizzaIngredientsVM>> GetPizzasIngredients();
        public Task<bool> CreateCustomPizzaIngredients(int pizzaId , List<int> selectedIngredientsIds);
        public Task<int> CreateCustomPizza(CustomerPizzasVM pizza);
        public Task UpdateCustomPizzaPrice(int pizzaId, List<int> ingredientsIds);
        public decimal GetIngredientPriceById(int id);
        public Task<Pizza?> GetPizzaByIdAsync(int id);
        public decimal GetPizzaPriceByPizzaId(int pizzaId);
       

    }
}
