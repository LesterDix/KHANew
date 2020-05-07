using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightCostByAwb
    {
        public string AwbNo { get; set; }
        public int Week { get; set; }
        public string Type { get; set; }
        public decimal? Chg { get; set; }
        public decimal? Cst { get; set; }
    }
}
