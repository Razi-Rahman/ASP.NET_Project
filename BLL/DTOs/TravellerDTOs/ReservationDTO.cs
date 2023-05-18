using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.TravellerDTOs
{
    public class ReservationDTO
    {
        public string ReservationID { get; set; }
        [Required]
        [StringLength(100)]
        public string CheckInDateTime { get; set; }
        [Required]
        [StringLength(100)]
        public string CheckOutDateTime { get; set; }
 
        public string TId { get; set; }
        public string PackageID { get; set; }
    }
}
