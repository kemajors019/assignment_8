using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PetShop.Models
{
    public class PetShopContextInitializer : DropCreateDatabaseIfModelChanges<PetShopContext>
    {
        protected override void Seed(PetShopContext context)
        {
            var pets = new List<Pet>()
            {
                new Pet() { Id = 001, Name = "Womack", PartialDesc = "1 year yellow Domestic Short Hair Cat", FullDesc = "I'm such a people pleaser.I'm a loving boy that lights up when people come to visit me.I will lure you in by talking to you. I can be very vocal and purr-suasive!" , DateReceived = DateTime.Parse("2016-01-01"), Price = 49.99M, Quantity = 1},
                new Pet() { Id = 002, Name = "Sunny", PartialDesc = "7 month Boxer mix", FullDesc = "I love people and will seek attention from you. For quiet time I especially enjoy being brushed.It will be fun training me because I'm motivated by treats" , DateReceived = DateTime.Parse("12-20-15"), Price = 299.99M, Quantity = 1},
                new Pet() { Id = 002, Name = "Dakota", PartialDesc = "5 month old Grey Tiger Short Hair", FullDesc = "I am a pretty girl with big eyes.  Come see me in person with my gorgeous eyes!  I would love to curl up on your lap." , DateReceived = DateTime.Parse("07-03-15"), Price = 49.99M, Quantity = 1},
                new Pet() { Id = 002, Name = "Rocky", PartialDesc = "2 year old Boxer/Great Dane mix" , FullDesc="I'm an energetic boy that will be a fun companion with some guidance.I'm a teenager and I'm used to doing what I want....and that's not acceptable.", DateReceived = DateTime.Parse("2-14-16"), Price = 299.99M, Quantity = 1},
                new Pet() { Id = 002, Name = "Petunia", PartialDesc = "3 Year old Tortiseshell Short Hair" , FullDesc="I'm a very friendly gal who loves to explore.I enjoy having my head and ears scratched. I will cuddle with you too, but when I want to.I also like to play. I'm a well-rounded gal.", DateReceived = DateTime.Parse("4-01-15"), Price = 49.99M, Quantity = 1},
            };

            pets.ForEach(p => context.Pets.Add(p));
            context.SaveChanges();
        }
    }
}