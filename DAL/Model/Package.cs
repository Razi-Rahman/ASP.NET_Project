using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Package
    {
        [Key]
        public string PackageID { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [ForeignKey("Package_Inclusion")]
        public string Inclusion_Id { get; set; }
        public virtual Package_Inclusion Package_Inclusion { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public Package()
        {
            Reservations = new List<Reservation>();
        }


    }
}
