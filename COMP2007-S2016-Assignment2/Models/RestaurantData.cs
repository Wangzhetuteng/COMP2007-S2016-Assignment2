using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace COMP2007_S2016_Assignment2.Models
{
    public class RestaurantData : DropCreateDatabaseAlways<RestaurantStoreContext>
    {
        protected override void Seed(RestaurantStoreContext context)
        {
            var foodtypes = new List<FoodType>
            {
                new FoodType { Name = "Appetizer" },
                new FoodType { Name = "Soup" },
                new FoodType { Name = "Meat" },
                new FoodType { Name = "Seafood" },
                new FoodType { Name = "vegetarian" },
                new FoodType { Name = "Noodles & Rice" }
            };


            new List<FoodItem>
            {


                new FoodItem { Title = "Spring Roll", FoodType = foodtypes.Single(g => g.Name == "Appetizer"), Price = 1.39M, ShortDescription = "Salty", DetailedDescription="Marinated cabbage and carrot wrap and deep fried", FoodItemThumbnailImageUrl = "/Assets/Images/SpringRollThumbnail.jpeg", FoodItemLargeImageUrl = "/Assets/Images/SpringRollLarge.jpg" },
                new FoodItem { Title = "Crispy Wontons", FoodType = foodtypes.Single(g => g.Name == "Appetizer"), Price = 3.50M, ShortDescription = "Salty", DetailedDescription="Our pork wontons served crispy with a sweet & sour sauce (6 pieces per order)", FoodItemThumbnailImageUrl = "/Assets/Images/CrispyWontonsThumbnail.jpeg", FoodItemLargeImageUrl = "/Assets/Images/CrispyWontonsLarge.jpg" },
                new FoodItem { Title = "Crispy Green Bean", FoodType = foodtypes.Single(g => g.Name == "Appetizer"), Price = 4.95M, ShortDescription = "Salty", DetailedDescription="More addictive than potato chips", FoodItemThumbnailImageUrl = "/Assets/Images/CrispyGreenBeanThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/CrispyGreenBeanLarge.jpg" },

                new FoodItem { Title = "Wonton Soup", FoodType = foodtypes.Single(g => g.Name == "Soup"), Price = 2.95M, ShortDescription = "Salty", DetailedDescription="Shrimp or Pork and vegetables in our homemade chicken broth", FoodItemThumbnailImageUrl = "/Assets/Images/WontonSoupThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/WontonSoupLarge.jpg"},
                new FoodItem { Title = "Hot & Sour Soup", FoodType = foodtypes.Single(g => g.Name == "Soup"), Price = 2.95M, ShortDescription = "Spicy & Sour", DetailedDescription="Tofu, Bamboo shoots and mushroom, balanced with hot pepper and vinega", FoodItemThumbnailImageUrl = "/Assets/Images/Hot&SourSoupThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/Hot&SourSoupLarge.jpe" },
                new FoodItem { Title = "Egg Drop Soup", FoodType = foodtypes.Single(g => g.Name == "Soup"), Price = 2.95M, ShortDescription = "Salty", DetailedDescription="A traditional favorite", FoodItemThumbnailImageUrl = "/Assets/Images/EggDropSoupThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/EggDropSoupLarge.jpg" },

                new FoodItem { Title = "Kung Pao Chicken", FoodType = foodtypes.Single(g => g.Name == "Meat"), Price = 10.25M, ShortDescription = "Salty & Spicy", DetailedDescription="Quick-fried with cashew nuts, chili peppers and onions. Our hot favorite", FoodItemThumbnailImageUrl = "/Assets/Images/KungPaoChickenThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/KungPaoChikenLarge.jpeg" },
                new FoodItem { Title = "Moo shu Beef", FoodType = foodtypes.Single(g => g.Name == "Meat"), Price = 9.95M, ShortDescription = "Salty & Spicy", DetailedDescription="A Chinese classic served with julienne vegetables, hoisin sauce and thin pancakes", FoodItemThumbnailImageUrl = "/Assets/Images/MooShuBeefThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/MooShuBeefLarge.jpg" },
                new FoodItem { Title = "Salt & spicy Ribs", FoodType = foodtypes.Single(g => g.Name == "Meat"), Price = 8.85M, ShortDescription = "Salty & Spicy", DetailedDescription="Deep fried boneless spare ribs seasoned with spicy salt, chili & herbs", FoodItemThumbnailImageUrl = "/Assets/Images/Salt&SpicyRibsThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/Salt&SpicyRibsLarge.jpg" },

                new FoodItem { Title = "Jumbo Shrimps", FoodType = foodtypes.Single(g => g.Name == "Seafood"), Price = 15.25M, ShortDescription = "Spicy", DetailedDescription="Large shrimps served on a skillet with vegetables. Topped with our spicy garlic sauce", FoodItemThumbnailImageUrl = "/Assets/Images/JumboShrimpsThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/JumboShrimpsLarge.jpg" },
                new FoodItem { Title = "Shrimp with Lobster Sauce", FoodType = foodtypes.Single(g => g.Name == "Seafood"), Price = 12.50M, ShortDescription = "Salty", DetailedDescription="Garlic white wine sauce with Chinese black beans, mushroom, onion and egg",FoodItemThumbnailImageUrl = "/Assets/Images/ShrimpwithLobsterSauceThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/ShrimpwithLobsterSauceLarge.jpg" },
                new FoodItem { Title = "Sweet Chilli Shrimp", FoodType = foodtypes.Single(g => g.Name == "Seafood"), Price = 13.50M, ShortDescription = "Sweet & Spicy", DetailedDescription="Hand-battered shrimp prepared to order and tossed in a spicy chilli sauce",FoodItemThumbnailImageUrl = "/Assets/Images/SweetChilliShrimpThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/SweetChilliShrimpLarge.jpg" },

                new FoodItem { Title = "Ma po Tofu", FoodType = foodtypes.Single(g => g.Name == "vegetarian"), Price = 7.85M, ShortDescription = "Salty &　Spicy", DetailedDescription="Sichuan’s famous dish of soft tofu in a vegetarian sauce with peas and carrots",FoodItemThumbnailImageUrl = "/Assets/Images/MaPoToFuThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/MaPoToFuLarge.jpg" },
                new FoodItem { Title = "Corn with Cashew Nuts", FoodType = foodtypes.Single(g => g.Name == "vegetarian"), Price = 8.25M, ShortDescription = "Sweet", DetailedDescription="Golden corn stir-fried cashew nuts and vegetable with a touch of sesame oil",FoodItemThumbnailImageUrl = "/Assets/Images/CornwithCashewNutsThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/CornwithCashewNutsLarge.jpg" },
                new FoodItem { Title = "Mu Shu Vegetables", FoodType = foodtypes.Single(g => g.Name == "vegetarian"), Price = 8.95M, ShortDescription = "Sweet", DetailedDescription="A Chinese classic served with julienne vegetables, hoisin sauce and thin pancakes",FoodItemThumbnailImageUrl = "/Assets/Images/MuShuVegetablesThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/MuShuVegetablesLarge.jpg" },

                new FoodItem { Title = "Cantonese Fried Rice", FoodType = foodtypes.Single(g => g.Name == "Noodles & Rice"), Price = 8.95M, ShortDescription = "Salty", DetailedDescription="Combination of shrimp, BBQ pork and vegetable",FoodItemThumbnailImageUrl = "/Assets/Images/CantoneseFriedRiceThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/CantoneseFriedRiceLarge.jpg" },
                new FoodItem { Title = "Cantonese Chow Mein", FoodType = foodtypes.Single(g => g.Name == "Noodles & Rice"), Price = 11.95M, ShortDescription = "Salty", DetailedDescription="Egg noodles stir fired with chicken, BBQ pork, shrimps and vegetables",FoodItemThumbnailImageUrl = "/Assets/Images/CantoneseChowMeinThumbnail.jpe", FoodItemLargeImageUrl = "/Assets/Images/CantoneseChowMeinLarge.jpe" },
                new FoodItem { Title = "Shanghai Noodle", FoodType = foodtypes.Single(g => g.Name == "Noodles & Rice"), Price = 9.50M, ShortDescription = "Salty", DetailedDescription="Thick noodle stir-fried with pork and cabbage",FoodItemThumbnailImageUrl = "/Assets/Images/ShanghaiNoodleThumbnail.jpg", FoodItemLargeImageUrl = "/Assets/Images/ShanghaiNoodleLarge.jpg" },
            }.ForEach(a => context.FoodItems.Add(a));
        }
    }
}
