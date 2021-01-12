using Microsoft.EntityFrameworkCore;

namespace ZbazinersBar.Models {
    public class BarDbContext : DbContext {
        public BarDbContext(DbContextOptions<BarDbContext> options) : base(options) { }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
