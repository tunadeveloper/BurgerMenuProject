using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
	public class Gallery
	{
        [Key]
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
    }
}