using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightCostAndCharge
    {
        public int CnsmentId { get; set; }
        public string InvoiceNo { get; set; }
        public string Type { get; set; }
        public int Week { get; set; }
        public string AwbNo { get; set; }
        public string Airline { get; set; }
        public DateTime? ShipDate { get; set; }
        public string FreightInvoice { get; set; }
        public string Cstmer { get; set; }
        public string CnsgneeId { get; set; }
        public int? ActBoxes { get; set; }
        public double? ActKg { get; set; }
        public double? KgBox { get; set; }
        public string ChgUnt { get; set; }
        public decimal? RateUntUsd { get; set; }
        public decimal? FrtChgUsd { get; set; }
        public double? DeadUnts { get; set; }
        public decimal? DeadChgUsd { get; set; }
        public decimal? OthrChgUsd { get; set; }
        public string OthrChgDesc { get; set; }
        public decimal? TotChgUsd { get; set; }
        public decimal? FrtCstUsd { get; set; }
        public string Sundry1 { get; set; }
    }
}
