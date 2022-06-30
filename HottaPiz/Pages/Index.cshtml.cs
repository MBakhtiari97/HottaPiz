using HottaPiz.DataLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HottaPiz.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IGenericRepository<DataLayer.Entities.Pizza.Pizza> _repository;

        public IndexModel(IGenericRepository<DataLayer.Entities.Pizza.Pizza> repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public IQueryable<DataLayer.Entities.Pizza.Pizza> Pizzas { get; set; }

        public void OnGet()
        {
            Pizzas = _repository.GetAll();
        }
    }
}