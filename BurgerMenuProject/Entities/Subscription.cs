using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
	public class Subscription
	{
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;
    }
}