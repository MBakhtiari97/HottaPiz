using HottaPiz.DataLayer.Entities.Pizza;
using HottaPiz.DataLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IGenericRepository<Pizza> _repository;

        public IndexModel(IGenericRepository<Pizza> repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public IQueryable<Pizza> Pizzas { get; set; }

        public void OnGet()
        {
            Pizzas = _repository.GetAll();
        }
    }
}