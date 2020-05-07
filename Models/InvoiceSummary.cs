using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class InvoiceSummary
    {
        public int CnsmentId { get; set; }
        public string ProductLine { get; set; }
        public double? NoCartons { get; set; }
        public int? NoStems { get; set; }
        public string ChgUnt { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public string CrncyCode { get; set; }
        public decimal? CrncyValue { get; set; }
        public string TransType { get; set; }
    }
}
