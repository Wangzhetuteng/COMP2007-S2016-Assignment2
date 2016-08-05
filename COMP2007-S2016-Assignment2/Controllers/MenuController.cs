using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Assignment2.Models;

/* File Name: COMP2007_S2016_Assignment2
 * Author: Yandong Wang  200277628
 * File Description: Create a website that allow customer to view the cuisines.
 * WebSite Name: Garden Restaurant
 */

namespace COMP2007_S2016_Assignment2.Controllers
{

    public class MenuController : Controller
    {
        RestaurantStoreContext storeDB = new RestaurantStoreContext();
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            List<FoodType> foodtypes = storeDB.FoodTypes.ToList();

            return View(foodtypes);
        }




        //
        // GET: /Store/Browse?type=Appetizer

        public ActionResult Browse(string foodtype = "Appetizer")
        {
            // Retrieve Food Type and its Associated Food Items from database
            FoodType foodtypeModel = storeDB.FoodTypes.Include("FoodItems").Single(g => g.Name == foodtype);

            return View(foodtypeModel);
        }





        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            FoodItem fooditem = storeDB.FoodItems.Find(id);

            return View(fooditem);
        }





    }
}