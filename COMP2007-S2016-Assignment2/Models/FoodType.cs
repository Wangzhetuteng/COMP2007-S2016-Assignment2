using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


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

        public virtual int FoodTypeId { get; set; }

        [Display(Name = "Food Type")]
        public virtual string Name { get; set; }
        public virtual List<FoodItem> FoodItems { get; set; }


    }
}