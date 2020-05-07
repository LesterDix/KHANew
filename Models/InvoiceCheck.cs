using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class InvoiceCheck
    {
        public string Type { get; set; }
        public int Week { get; set; }
        public int? Invoice { get; set; }
        public string Cstmer { get; set; }
        public string Currency { get; set; }
        public int? NoChgUnts { get; set; }
        public decimal RateCrncyStem { get; set; }
        public decimal CrncyChg { get; set; }
        public decimal? CrncyValue { get; set; }
    }
}
