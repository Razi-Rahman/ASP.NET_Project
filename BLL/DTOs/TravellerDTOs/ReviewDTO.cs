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
    public class ReviewDTO
    {
        public string ReviewId { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Comment { get; set; }
        public string TId { get; set; }

        public string Inclusion_Id { get; set; }
    }
}
