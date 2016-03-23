using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetShop.Models
{
    public class PetShopContext : DbContext
    {
        public PetShopContext() : base("name=PetShopContext") { }

        public DbSet<Pet> Pets { get; set; }
    }
}