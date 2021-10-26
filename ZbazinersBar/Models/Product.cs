using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZbazinersBar.Models {
    public class Item {
        public long ItemID { get; set; }

        [Required(ErrorMessage = "Missing item name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Missing item description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Missing category")]
        public string Category { get; set; }

        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Error: Price has to be a positive number")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
    }
}