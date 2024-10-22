using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
    public class About
    {
        
        public int Id { get; set; }
        public string WelcomeImage { get; set; }
        public string WelcomeText { get; set; }
        public string AboutImage { get; set; }
        public string AboutText { get; set; }
    }
}