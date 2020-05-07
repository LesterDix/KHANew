using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightRemittances
    {
        public string InvoiceNo { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public DateTime RemitDate { get; set; }
        public string CstmrRemitno { get; set; }
        public string ReceiptNo { get; set; }
        public decimal RemitValue { get; set; }
    }
}
