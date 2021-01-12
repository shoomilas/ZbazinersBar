using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ZbazinersBar.Infrastructure;
using ZbazinersBar.Models;
using System.Linq;

namespace ZbazinersBar.Pages {

    public class CartModel : PageModel {
        private IStoreRepository repository;

        public CartModel(IStoreRepository repo, Cart cartService) {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl) {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(long ItemId, string returnUrl) {
            Item Item = repository.Items
                .FirstOrDefault(p => p.ItemID == ItemId);
            Cart.AddItem(Item, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long ItemId, string returnUrl) {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Item.ItemID == ItemId).Item);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
