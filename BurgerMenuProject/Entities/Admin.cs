﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}