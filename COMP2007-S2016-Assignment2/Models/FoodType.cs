using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Assignment2.Models;

namespace COMP2007_S2016_Assignment2.Models
{
    public class FoodType
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodType()
        {

        }
        /// <summary>
        /// This constructor takes one parameter = Name
        /// </summary>
        /// <param name="Name"></param>
        public FoodType(string Name)
        {
            this.Name = Name;
        }

        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SubMenu> SubMenus { get; set; }
    }
}