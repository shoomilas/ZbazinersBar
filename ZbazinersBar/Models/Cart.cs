using System.Collections.Generic;
using System.Linq;

namespace ZbazinersBar.Models {
    public class Cart {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Item Item, int quantity) {
            CartLine line = Lines
                .Where(p => p.Item.ItemID == Item.ItemID)
                .FirstOrDefault();

            if (line == null) {
                Lines.Add(new CartLine {
                    Item = Item,
                    Quantity = quantity
                });
            } else {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Item Item) =>
            Lines.RemoveAll(l => l.Item.ItemID == Item.ItemID);

        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Item.Price * e.Quantity);

        public virtual void Clear() => Lines.Clear();
    }

    public class CartLine {
        public int CartLineID { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
