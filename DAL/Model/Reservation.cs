using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Reservation
    {
        [Key]
        public string ReservationID { get; set; }
        [Required]
        [StringLength(100)]
        public string CheckInDateTime { get; set; }
        [Required]
        [StringLength(100)]
        public string CheckOutDateTime { get; set;}
        [ForeignKey("Traveller")]
        public string TId { get; set; }
        public virtual Traveller Traveller { get; set; }
        [ForeignKey("Package")]
        public string PackageID { get; set; }
        public virtual Package Package { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public Reservation() 
        {
            Payments = new List<Payment>();
        }
    }
}
