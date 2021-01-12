using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ZbazinersBar.Models {

    public class Order {

        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Missing name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Missing  address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Missing city name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Missing country info")]
        public string Country { get; set; }

        public bool AdditionalGenuineTrdelnik { get; set; }

        [Required(ErrorMessage = "Missing state info")]
        public string State { get; set; }

        [BindNever]
        public bool Shipped { get; set; }
    }
}
