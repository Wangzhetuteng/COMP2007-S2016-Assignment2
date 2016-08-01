using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COMP2007_S2016_Assignment2.Models
{
    public class RestaurantData : DropCreateDatabaseIfModelChanges<RestaurantStoreContext>
    {
        protected override void Seed(RestaurantStoreContext context)
        {
            var foodtypes = new List<FoodType>
            {
                new FoodType { Name = "Appetizer" },
                new FoodType { Name = "Soup" },
                new FoodType { Name = "Meat" },
                new FoodType { Name = "Vegetarian" },
                new FoodType { Name = "Noodles & Rice" },
            };

            var shortdescriptions = new List<ShortDescription>
            {
                new ShortDescription {},

            };

            new List<SubMenu>
            {

                new SubMenu { Title = "Egg Roll", FoodType = foodtypes.Single(g => g.Name == "Appetizer"), Price = 1.39M, ShortDescription = shortdescriptions.Single(a => a.Flavour == "Egg wrap and deep fried"), SubMenuUrl = "/Assets/images/SpringRoll.gif" },

            }.ForEach(a => context.SubMenus.Add(a));
        }
    }
}
