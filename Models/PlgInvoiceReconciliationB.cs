using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class PlgInvoiceReconciliationB
    {
        public int TransId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Sundry1 { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string ProductLine { get; set; }
        public string Cultivar { get; set; }
        public string Colour { get; set; }
        public string ChgUnt { get; set; }
        public int NoChgUnts { get; set; }
        public string SupplierId { get; set; }
        public string CrncyCode { get; set; }
        public decimal ForexUsdRate { get; set; }
        public decimal? CrncyChgUnt { get; set; }
        public decimal? UsdValue { get; set; }
        public decimal? InvDnValue { get; set; }
        public int? CnNo { get; set; }
        public DateTime? CnDate { get; set; }
        public double CnValue { get; set; }
        public string TransType { get; set; }
    }
}
