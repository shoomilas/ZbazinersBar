using Microsoft.AspNetCore.Mvc;
using ZbazinersBar.Models;
using System.Linq;

namespace ZbazinersBar.Controllers {

    public class OrderController : Controller {
        private IOrderRepository repository;
        private Cart cart;

        public OrderController(IOrderRepository repoService, Cart cartService) {
            repository = repoService;
            cart = cartService;
        }

        public ViewResult Purchase() => View(new Order());

        [HttpPost]
        public IActionResult Purchase(Order order) {
            if (cart.Lines.Count() == 0) {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid) {
                order.Lines = cart.Lines.ToArray();
                repository.SaveOrder(order);
                cart.Clear();
                return RedirectToPage("/Done", new { orderId = order.OrderID });
            } else {
                return View();
            }
        }
    }
}
