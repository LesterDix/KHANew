using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Cnsment
    {
        public Cnsment()
        {
            CnsLines = new HashSet<CnsLines>();
        }

        public int CnsmentId { get; set; }
        public string Exporter { get; set; }
        public string InvoiceNo { get; set; }
        public int Week { get; set; }
        public string DepDow { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string Cstmer { get; set; }
        public string CnsgneeId { get; set; }
        public string Currency { get; set; }
        public decimal ForexUsdRate { get; set; }
        public int ShipId { get; set; }
        public string COfONo { get; set; }
        public string BoeNo { get; set; }
        public string PhytoNo { get; set; }
        public string FreightInvoice { get; set; }
        public string Status { get; set; }
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
        public decimal? OthrChgUsd { get; set; }
        public string OthrChgDesc { get; set; }
        public decimal? TotChgUsd { get; set; }
        public decimal? FrtCstUsd { get; set; }
        public string Sundry1 { get; set; }
        public string Sundry2 { get; set; }
        public string Container1 { get; set; }
        public string Container2 { get; set; }
        public string Container3 { get; set; }
        public string Container4 { get; set; }
        public string Container5 { get; set; }
        public string Container6 { get; set; }
        public string Container7 { get; set; }
        public string Container8 { get; set; }

        public virtual Consignee Cnsgnee { get; set; }
        public virtual Customer CstmerNavigation { get; set; }
        public virtual Currency CurrencyNavigation { get; set; }
        public virtual Exporter ExporterNavigation { get; set; }
        public virtual Shipment Ship { get; set; }
        public virtual ICollection<CnsLines> CnsLines { get; set; }
    }
}
