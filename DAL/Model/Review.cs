using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Review
    {
        [Key]
        public string ReviewId { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Comment { get; set; }

        [ForeignKey("Traveller")]
        public string TId { get; set; }
        public virtual Traveller Traveller { get; set; }
        [ForeignKey("Package_Inclusion")]
        public string Inclusion_Id { get; set; }
        public virtual Package_Inclusion Package_Inclusion { get; set; }
    }
}
