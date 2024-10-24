using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
	public class Contact
	{
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MapUrl { get; set; }
        
    }
}