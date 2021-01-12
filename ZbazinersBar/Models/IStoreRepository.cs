using System.Linq;

namespace ZbazinersBar.Models {
    public interface IStoreRepository {

        IQueryable<Item> Items { get; }

        void SaveItem(Item p);
        void CreateItem(Item p);
        void DeleteItem(Item p);
    }
}
