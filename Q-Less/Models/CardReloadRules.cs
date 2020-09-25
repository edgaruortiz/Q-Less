using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class CardReloadRules : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var transaction = (TransportCardReloadHistory)validationContext.ObjectInstance;
            return transaction.CardValue > transaction.CashValue ? new ValidationResult("Reload amount must be less than or equal to the Cash Value") : ValidationResult.Success;

        }
    }
}