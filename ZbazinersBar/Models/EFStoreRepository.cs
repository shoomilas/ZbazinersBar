using System.Linq;

namespace ZbazinersBar.Models {
    public class EFStoreRepository : IStoreRepository {
        private BarDbContext BarDbContext;

        public EFStoreRepository(BarDbContext context) {
            BarDbContext = context;
        }

        public IQueryable<Item> Items => BarDbContext.Items;
        public void DeleteItem(Item p) {
            BarDbContext.Remove(p);
            BarDbContext.SaveChanges();
        }
        public void CreateItem(Item p) {
            BarDbContext.Add(p);
            BarDbContext.SaveChanges();
        }

        public void SaveItem(Item p) {
            BarDbContext.SaveChanges();
        }
    }
}