using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Assignment2.Models
{
    [Bind(Exclude = "SubMenuId")]
    public class SubMenu
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public SubMenu()
        {

        }
        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public SubMenu(string Title)
	    {
            this.Title = Title;
        }

        [ScaffoldColumn(false)]
        public virtual int SubMenuId { get; set; }
        [DisplayName("Type")]
        public virtual int TypeId { get; set; }


        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }
        [DisplayName("SubMenu URL")]

        public virtual string SubMenuUrl { get; set; }
        public virtual FoodType Type { get; set; }

    }
}