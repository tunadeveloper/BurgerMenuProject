using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Entities
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PeopleCount { get; set; }
        public DateTime Time { get; set; }
        public string Message { get; set; }
        public string ReservationStatus { get; set; }

    }
}