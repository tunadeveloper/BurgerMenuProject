using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
	public class SocialMedia
	{
		public int Id { get; set; }
        public string SocialMedianame { get; set; }
        public string SocialMediaUrl { get; set; }
        public string SocialMediaIcon { get; set; }
    }
}