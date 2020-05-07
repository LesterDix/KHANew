using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightFob
    {
        public int CnsmentId { get; set; }
        public int? Week { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Cstmer { get; set; }
        public double? Cartons { get; set; }
        public int? Stems { get; set; }
        public string Currency { get; set; }
        public decimal? RateCrncyStem { get; set; }
        public decimal? FrtChg { get; set; }
    }
}
