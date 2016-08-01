using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_S2016_Assignment2.Models
{
    public class ShortDescription
    {
        public virtual int ShortDescriptionId { get; set; }

        public virtual string Flavour { get; set; }
    }
}