using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FrtCheck
    {
        public string Type { get; set; }
        public int Week { get; set; }
        public int? Invoice { get; set; }
        public string Cstmer { get; set; }
        public decimal? FrtChgUsd { get; set; }
        public decimal? RateUntUsd { get; set; }
        public string ChgUnt { get; set; }
        public double? KgBox { get; set; }
        public int? ActBoxes { get; set; }
        public double? ActKg { get; set; }
    }
}
