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
        #region Get All Pizzas

        public Task<List<Pizza>> GetAllPizzasAsync();

        #endregion

        #region Update Pizza

        public Task<bool> UpdatePizzaAsync(UpdatePizzaVM pizzaDetails);

        #endregion

        #region Get Update Pizza VM

        public UpdatePizzaVM GetUpdatePizzaVMById(int pizzaId);

        #endregion

        #region Create New Pizza

        public Task<bool> CreatePizzaAsync(CreatePizzaVM pizzaDetails);

        #endregion

        #region Get Pizza Ingredients

        public Task<List<PizzaIngredientsVM>> GetPizzasIngredients();

        #endregion

        #region Create Custom Pizzas Ingredients

        public Task<bool> CreateCustomPizzaIngredients(int pizzaId, List<int> selectedIngredientsIds);

        #endregion

        #region Create Custom Pizzas

        public Task<int> CreateCustomPizza(CustomerPizzasVM pizza);

        #endregion

        #region Update Custom Pizzas Price After Creating a new one

        public Task UpdateCustomPizzaPrice(int pizzaId, List<int> ingredientsIds);

        #endregion

        #region Get Ingredients Price By Ingredient Id

        public decimal GetIngredientPriceById(int id);

        #endregion

        #region Get Pizza By Pizza Id

        public Task<Pizza?> GetPizzaByIdAsync(int id);

        #endregion

        #region Get Pizza Price By Pizza Id

        public decimal GetPizzaPriceByPizzaId(int pizzaId);

        #endregion

        #region Remove Pizza By Pizza Id

        public Task<bool> RemovePizzaByPizzaIdAsync(int pizzaId);

        #endregion

        #region Get Pizza Details VM By Pizza Id

        public Task<PizzaDetailsVM> GetPizzaDetailsByPizzaIdAsync(int pizzaId);

        #endregion

        #region Get Pizza Ingredient Names By Pizza Id

        public Task<List<PizzaIngredientsNamesVM>> GetPizzaIngredientsNamesByPizzaIdAsync(int pizzaId);

        #endregion

    }
}
