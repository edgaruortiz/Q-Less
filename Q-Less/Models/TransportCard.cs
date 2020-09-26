using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class TransportCard
    {
        public int Id { get; set; }

        [Display(Name ="Unique ID")]
        [Required]
        public int TransportCardUniqueId { get; set; }

        public DateTime DatePurchased { get; set; }

        public int CardTypeId { get; set; }

        public CardType CardType { get; set; }

        [Display(Name = "Initial Amount")]
        public double CardValue { get; set; }

        [Display(Name = "ID Number")]
        public string Identification { get; set; }

        public DateTime LastUsed { get; set; }

    }
}