using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class InvoiceRemitCn
    {
        public string InvoiceNo { get; set; }
        public int Week { get; set; }
        public string Invoice { get; set; }
        public string Cstmer { get; set; }
        public string CrncyCode { get; set; }
        public decimal? InvDnValue { get; set; }
        public decimal? CnValue { get; set; }
        public decimal? RemitValue { get; set; }
        public decimal? BalValue { get; set; }
    }
}
