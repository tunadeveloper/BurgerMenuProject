using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
	public class CreditCard
	{
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string CardNumber { get; set; }
        public string expirationDate { get; set; }
        public string Cvv { get; set; }

    }
}