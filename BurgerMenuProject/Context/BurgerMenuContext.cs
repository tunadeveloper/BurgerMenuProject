using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Context
{
    public class BurgerMenuContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }  
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
    }
}