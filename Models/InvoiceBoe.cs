using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class InvoiceBoe
    {
        public string InvoiceNo { get; set; }
        public string BoeNo { get; set; }
        public string CrncyCode { get; set; }
        public decimal? CrncyValue { get; set; }
    }
}
