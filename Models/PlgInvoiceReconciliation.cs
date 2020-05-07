using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class PlgInvoiceReconciliation
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
        public decimal CrncyChgUnt { get; set; }
        public decimal? UsdValue { get; set; }
        public decimal InvDnValue { get; set; }
        public int? CnNo { get; set; }
        public DateTime? CnDate { get; set; }
        public decimal CnValue { get; set; }
        public int? RemitNo { get; set; }
        public string CstmerRemitno { get; set; }
        public DateTime? RemitDate { get; set; }
        public decimal RemitValue { get; set; }
        public decimal? BalValue { get; set; }
        public string TransType { get; set; }
        public decimal? RemitAmnt { get; set; }
        public string Narration { get; set; }
    }
}
