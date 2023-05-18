using DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AdminDTOs
{
    public class ReservationDTO
    {
        public string ReservationID { get; set; }
        [Required]
        public string CheckInDateTime { get; set; }
        [Required]
        public string CheckOutDateTime { get; set; }
        public string TId { get; set; }
        public virtual Traveller Traveller { get; set; }
        public string PackageID { get; set; }
    }
}
