using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Assignment2.Models
{
    [Bind(Exclude = "AlbumId")]
    public class Album
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Album()
        {

        }
        /// <summary>
        /// This constructor takes one parameter - Title
        /// </summary>
        /// <param name="Title"></param>
        public Album(string Title)
	    {
            this.Title = Title;
        }

        [ScaffoldColumn(false)]
        public virtual int AlbumId { get; set; }
        [DisplayName("Genre")]
        public virtual int GenreId { get; set; }
        [DisplayName("Artist")]
        public virtual int ArtistId { get; set; }

        public virtual string Title { get; set; }

        public virtual decimal Price { get; set; }
        [DisplayName("Album Art URL")]

        public virtual string AlbumArtUrl { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Artist Artist { get; set; }
    }
}