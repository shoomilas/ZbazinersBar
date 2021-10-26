using System.Collections.Generic;
using ZbazinersBar.Models;

namespace ZbazinersBar.Models.ViewModels {
    public class ItemsListViewModel {
        public string CurrentCategory { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
