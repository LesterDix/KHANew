using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class PdFreightInvoiceRecon
    {
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Week { get; set; }
        public string Cstmer { get; set; }
        public string Currency { get; set; }
        public DateTime? RemitDate { get; set; }
        public string CstmrRemitno { get; set; }
        public string ReceiptNo { get; set; }
        public decimal? FrtChg { get; set; }
        public decimal RemitValue { get; set; }
        public decimal? BalValue { get; set; }
    }
}
