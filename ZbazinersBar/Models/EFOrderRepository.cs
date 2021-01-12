using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ZbazinersBar.Models {

    public class EFOrderRepository : IOrderRepository {
        private BarDbContext context;
        public EFOrderRepository(BarDbContext ctx) {
            context = ctx;
        }
        
        public IQueryable<Order> Orders => context.Orders
                            .Include(o => o.Lines)
                            .ThenInclude(l => l.Item);
        public void SaveOrder(Order order) {
            context.AttachRange(order.Lines.Select(l => l.Item));
            if (order.OrderID == 0) {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}
