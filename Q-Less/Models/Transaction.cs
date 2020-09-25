using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public int TransportCardId { get; set; }

        public double Amount { get; set; }

        [MaxLength(100)]
        public string EntryPoint { get; set; }

        [MaxLength(100)]
        public string ExitPoint { get; set; }

        public DateTime DateStamp { get; set; }
    }
}