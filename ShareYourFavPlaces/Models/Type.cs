using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShareYourFavPlaces.Models
{
    public class Type
    {
        //set the pk of model Type
        public int TypeId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Contents are required.")]
        public string Name { get; set; }

        //reference to child object
        public List<Post> Posts { get; set; }

    }
}
