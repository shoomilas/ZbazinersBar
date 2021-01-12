using System.Linq;

namespace ZbazinersBar.Models {
    public class EFStoreRepository : IStoreRepository {
        private StoreDbContext context;

        public EFStoreRepository(StoreDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Item> Items => context.Items;

        public void CreateItem(Item p) {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteItem(Item p) {
            context.Remove(p);
            context.SaveChanges();
        }

        public void SaveItem(Item p) {
            context.SaveChanges();
        }
    }
}
