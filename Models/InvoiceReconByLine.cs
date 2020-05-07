using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class InvoiceReconByLine
    {
        public DateTime InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public string Sundry1 { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string ProductLine { get; set; }
        public string ChgUnt { get; set; }
        public int? TotChgUnt { get; set; }
        public string CrncyCode { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public decimal? Value { get; set; }
        public decimal? CrValue { get; set; }
        public DateTime? RemitDate { get; set; }
        public decimal? RmtValue { get; set; }
        public decimal? BalVal { get; set; }
        public decimal? RmtAmt { get; set; }
    }
}
