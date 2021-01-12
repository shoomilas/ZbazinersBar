using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ZbazinersBar.Infrastructure;

namespace ZbazinersBar.Models {

    public class SessionCart : Cart {

        public static Cart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart sessionCart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            sessionCart.Session = session;
            return sessionCart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Item Item, int quantity) {
            base.AddItem(Item, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Item Item) {
            base.RemoveLine(Item);
            Session.SetJson("Cart", this);
        }

        public override void Clear() {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
