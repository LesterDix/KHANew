using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class ShipCnsmentDetail
    {
        public int ShipId { get; set; }
        public string AwbNo { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipDow { get; set; }
        public string DestCode { get; set; }
        public int? KgBooked { get; set; }
        public int? KgActual { get; set; }
        public int? KgCharged { get; set; }
        public decimal? RateUsdKg { get; set; }
        public decimal? OtherUsdKg { get; set; }
        public decimal? OtherUsdShpmnt { get; set; }
        public decimal? TotalChgUsd { get; set; }
        public string Exporter { get; set; }
        public string Cstmer { get; set; }
        public string InvoiceNo { get; set; }
        public string BoeNo { get; set; }
        public int Week { get; set; }
        public string Currency { get; set; }
        public decimal ForexUsdRate { get; set; }
        public string CnsgneeId { get; set; }
        public int? BookedBoxes { get; set; }
        public int? BookedKg { get; set; }
        public int? ActBoxes { get; set; }
        public double? ActKg { get; set; }
        public double? KgBox { get; set; }
        public string ChgUnt { get; set; }
        public decimal? RateUntUsd { get; set; }
        public decimal? FrtChgUsd { get; set; }
        public double? DeadUnts { get; set; }
        public decimal? DeadChgUsd { get; set; }
        public decimal? TotChgUsd { get; set; }
    }
}
