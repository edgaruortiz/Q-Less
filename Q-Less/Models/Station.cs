using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class Station
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string StationName { get; set; }
        [Required]
        public int line { get; set; }
    }
}