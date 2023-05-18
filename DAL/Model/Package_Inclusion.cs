using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Package_Inclusion

    {
        [Key]
        public string Inclusion_Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Phone { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

        public Package_Inclusion()
        {
            Packages = new List<Package>();
            Payments = new List<Payment>();
            Reviews = new List<Review>();
        }
    }
}
