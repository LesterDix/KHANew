using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class TranscationReconciliation
    {
        public int TransId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string Sundry1 { get; set; }
        public string CrncyCode { get; set; }
        public decimal? InvDnVal { get; set; }
        public DateTime CnDate { get; set; }
        public decimal CnValues { get; set; }
        public DateTime RemitDate { get; set; }
        public decimal RemitValue { get; set; }
        public string CstmerRemitno { get; set; }
    }
}
