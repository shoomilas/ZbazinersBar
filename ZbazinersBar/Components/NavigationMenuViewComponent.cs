using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ZbazinersBar.Models;

namespace ZbazinersBar.Components {
    public class NavigationMenuViewComponent : ViewComponent {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo) {
            repository = repo;
        }

        public IViewComponentResult Invoke() {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Items
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}