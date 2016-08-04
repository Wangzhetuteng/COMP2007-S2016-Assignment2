using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Assignment2.Models
{
    public class FoodItem
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public FoodItem()
        {

        }
        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public FoodItem(string Title)
        {
            this.Title = Title;
        }

        [Display(Name = "Food Item")]
        public virtual int FoodItemId { get; set; }

        [DisplayName("Food Type")]
        public virtual int FoodTypeId { get; set; }
        [DisplayName("Short Description")]
        public virtual int ShortDescriptionId { get; set; }
        [DisplayName("Detailed Description")]
        public virtual int DetailedDescriptionId { get; set; }
        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }
        [DisplayName("Food Item Thumbnail URL")]
        public virtual string FoodItemThumbnailImageUrl { get; set; }


        [DisplayName("Food Item Large Image URL")]
        public virtual string FoodItemLargeImageUrl { get; set; }

        public virtual FoodType FoodType { get; set; }

        public virtual string ShortDescription { get; set; }
        public virtual string DetailedDescription { get; set; }
    }
}