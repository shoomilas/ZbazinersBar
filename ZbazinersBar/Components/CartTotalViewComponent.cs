using Microsoft.AspNetCore.Mvc;
using ZbazinersBar.Models;

namespace ZbazinersBar.Components {
    public class CartTotalViewComponent : ViewComponent {
        private Cart cart;

        public CartTotalViewComponent(Cart cartService) {
            cart = cartService;
        }

        public IViewComponentResult Invoke() {
            return View(cart);
        }
    }
}