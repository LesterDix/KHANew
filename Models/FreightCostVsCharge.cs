using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightCostVsCharge
    {
        public DateTime? ShipDate { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string AwbNo { get; set; }
        public string Airline { get; set; }
        public string Type { get; set; }
        public decimal? FrtChg { get; set; }
        public decimal? FrtCost { get; set; }
        public double? ActKg { get; set; }
        public int? ActBoxes { get; set; }
    }
}
