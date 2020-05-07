using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class PlgCustomerReconciliationB
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Sundry1 { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string CrncyCode { get; set; }
        public decimal? InvDnValue { get; set; }
        public double? CnValue { get; set; }
    }
}
