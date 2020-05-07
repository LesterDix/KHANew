using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightInvoiceRecon
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Week { get; set; }
        public int? Invoice { get; set; }
        public int ShipId { get; set; }
        public string Cstmer { get; set; }
        public string CnsgneeId { get; set; }
        public string FreightInvoice { get; set; }
        public string AwbNo { get; set; }
        public string Flight1 { get; set; }
        public string Routing { get; set; }
        public int? BookedBoxes { get; set; }
        public int? BookedKg { get; set; }
        public int? ActBoxes { get; set; }
        public double? ActKg { get; set; }
        public decimal? FrtCstUsd { get; set; }
        public double? KgBox { get; set; }
        public string ChgUnt { get; set; }
        public decimal? RateUntUsd { get; set; }
        public double? DeadUnts { get; set; }
        public decimal? DeadChgUsd { get; set; }
        public decimal? OthrChgUsd { get; set; }
        public string OthrChgDesc { get; set; }
        public decimal TotFrtChg { get; set; }
        public decimal TotFrtRmt { get; set; }
        public decimal? Balance { get; set; }
        public string ReceiptNo { get; set; }
        public DateTime? RemitDate { get; set; }
    }
}
