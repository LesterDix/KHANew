using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightRemittanceTotal
    {
        public string InvoiceNo { get; set; }
        public DateTime RemitDate { get; set; }
        public string ReceiptNo { get; set; }
        public decimal? RemitTotal { get; set; }
    }
}
