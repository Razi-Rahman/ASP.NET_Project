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
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public string PaymentAmount { get; set; }
        [Required]
        public string TId { get; set; }
        [Required]
        public string Inclusion_Id { get; set; }
        [Required]
        public string ReservationID { get; set; }
    }
}
