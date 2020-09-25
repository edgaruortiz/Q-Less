using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q_Less.Models
{
    public class PriceMatrix
    {
        public int Id { get; set; }
        public int EntryStationid { get; set; }
        public int ExitStationid { get; set; }
        public double Price { get; set; }
    }
}