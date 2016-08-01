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

    public class StoreController : Controller
    {
        RestaurantStoreContext storeDB = new RestaurantStoreContext();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<FoodType> foodtypes = storeDB.FoodTypes.ToList();

            return View(foodtypes);
        }
        //
        // GET: /Store/Browse?type=Appetizer

        public ActionResult Browse(string foodtypes = "Appetizer")
        {
            // Retrieve Food Type and its Associated SubMenus from database
            FoodType foodtypeModel = storeDB.FoodTypes.Include("SubMenus").Single(g => g.Name == foodtypes);

            return View(foodtypeModel);
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            SubMenu submenu = storeDB.SubMenus.Find(id);

            return View(submenu);
        }
    }
}