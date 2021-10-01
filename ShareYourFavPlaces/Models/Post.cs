using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShareYourFavPlaces.Models
{
    public class Post
    {

        //add a primary key of the Post model
        [Display(Name = "Post ID")]
        public int PostId { get; set; }

        //add post title
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contents are required.")]
        public string Title { get; set; }

        //add place name
        [Display(Name ="Name of the Place")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contents are required.")]
        public string PlaceName { get; set; }

        //add the cost of the trip
        [Range(0.01,999999)]
        [Required]
        [Display(Name ="Cost of your Trip")]
        public int Cost { get; set; }

        //add the experience description
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contents are required.")]
        [Display(Name ="Experience Description")]
        public string Experience { get; set; }

        //add photo
        public string Photo { get; set; }

        //fk
        public int TypeId { get; set; }

        //reference parent object Type
        public Type Type { get; set; }
    }
}
