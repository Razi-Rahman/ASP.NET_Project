﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string TKey { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? Expired { get; set; }
        [Required]
        [ForeignKey("User")]
        public string Username { get; set; }
        public virtual User User { get; set; }
    }
}
