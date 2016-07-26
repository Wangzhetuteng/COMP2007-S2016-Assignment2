using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COMP2007_S2016_Assignment2.Models;

namespace COMP2007_S2016_Assignment2.Models
{
    public class Genre
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Genre()
        {

        }
        /// <summary>
        /// This constructor takes one parameter = Name
        /// </summary>
        /// <param name="Name"></param>
        public Genre(string Name)
        {
            this.Name = Name;
        }

        public int GenreID { get; set; }
        public string Name { get; set; }
    }
}