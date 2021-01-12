using System.Linq;

namespace ZbazinersBar.Models {
    public class EFStoreRepository : IStoreRepository {
        private StoreDbContext storeDbContext;

        public EFStoreRepository(StoreDbContext context) {
            storeDbContext = context;
        }

        public IQueryable<Item> Items => storeDbContext.Items;
        public void DeleteItem(Item p) {
            storeDbContext.Remove(p);
            storeDbContext.SaveChanges();
        }
        public void CreateItem(Item p) {
            storeDbContext.Add(p);
            storeDbContext.SaveChanges();
        }



        public void SaveItem(Item p) {
            storeDbContext.SaveChanges();
        }
    }
}
