using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class TransportCardReloadHistory
    {
        public int Id { get; set; }

        [Required]
        public int TransportCardUniqueId { get; set; }

        [Display(Name = "Cash Value")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "Value must be Greater Than Zero")]
        public double CashValue { get; set; }

        [Display(Name = "Card Value")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "Value must be Greater Than Zero")]
        [CardReloadRules]
        public double CardValue { get; set; }

        public DateTime DateStamp { get; set; }
    }
}