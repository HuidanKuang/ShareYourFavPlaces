using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShareYourFavPlaces.Models
{
    public class Post
    {

        [Range(1,9999999)]
        //[Display(Name = "Post ID")]
        //add a primary key of the Post model
        public int PostId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contents are required.")]
        public string Title { get; set; }

        public string PlaceName { get; set; }

        public int Cost { get; set; }

        public string Experience { get; set; }
    }
}
