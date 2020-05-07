using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Remittances
    {
        public int RemitNo { get; set; }
        public int TransId { get; set; }
        public string CstmerRemitno { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime RemitDate { get; set; }
        public decimal RemitValue { get; set; }
        public decimal? RemitAmnt { get; set; }
        public string Narration { get; set; }

        public virtual CnsLines Trans { get; set; }
    }
}
