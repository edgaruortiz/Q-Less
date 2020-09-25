using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class NewTransaction
    {
        public double Amount { get; set; }
        public DateTime DateStamp { get; set; }
        public string EntryPoint { get; set; }
        public string ExitPoint { get; set; }
        public int TransportCardId { get; set; }
    }
}