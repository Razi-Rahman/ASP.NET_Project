using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.AdminDTOs
{
    public class PackageDTO
    {
        public string PackageID { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int GroupSize { get; set; }
        public string Inclusion_Id { get; set; }
    }
}
