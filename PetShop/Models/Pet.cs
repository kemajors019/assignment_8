using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Pet
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PartialDesc { get; set; }
        public string FullDesc { get; set; }
        public DateTime DateReceived { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}