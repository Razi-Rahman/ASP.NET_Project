using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TravelAgencyContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Package_Inclusion> Packages_Inclusions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<User> Users { get;set; }
    }
}
