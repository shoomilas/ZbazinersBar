using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ZbazinersBar.Models;
using ZbazinersBar.Models.ViewModels;

namespace ZbazinersBar.Controllers {
    public class HomeController : Controller {
        private readonly IStoreRepository repository;
        public int PageSize = 5;

        public HomeController(IStoreRepository repo) {
            repository = repo;
        }

        public ViewResult Index(string category, int ItemPage = 1) {
            return View(new ItemsListViewModel {
                Items = repository.Items.Where(p => category == null || p.Category == category).OrderBy(p => p.ItemID).Skip((ItemPage - 1) * PageSize).Take(PageSize),
                    PagingInfo = new PagingInfo {
                        CurrentPage = ItemPage,
                            ItemsPerPage = PageSize,
                            TotalItems = category == null ?
                            repository.Items.Count() :
                            repository.Items.Where(e =>
                                e.Category == category).Count()
                    },
                    CurrentCategory = category
            });
        }
    }
}