using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
	public class UserMessage
	{
        public int Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}