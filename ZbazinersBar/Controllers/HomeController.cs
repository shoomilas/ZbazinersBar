using Microsoft.AspNetCore.Mvc;
using ZbazinersBar.Models;
using System.Linq;
using ZbazinersBar.Models.ViewModels;

namespace ZbazinersBar.Controllers {
    public class HomeController : Controller {
        private readonly IStoreRepository repository;
        public int PageSize = 6;

        public HomeController(IStoreRepository repo) {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
        {
            return View(new ProductsListViewModel
            {
                Products = repository.Products.Where(p => category == null || p.Category == category).OrderBy(p => p.ProductID).Skip((productPage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                                   repository.Products.Count() :
                                   repository.Products.Where(e =>
                                       e.Category == category).Count()
                },
                CurrentCategory = category
            });
        }
    }
}
