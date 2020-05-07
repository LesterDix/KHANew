using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            Cnsment = new HashSet<Cnsment>();
        }

        public int ShipId { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipDow { get; set; }
        public string DestCode { get; set; }
        public string AwbNo { get; set; }
        public string Flight1 { get; set; }
        public string Flight2 { get; set; }
        public string Flight3 { get; set; }
        public string Routing { get; set; }
        public string Container1 { get; set; }
        public string Container2 { get; set; }
        public string Container3 { get; set; }
        public string Container4 { get; set; }
        public string Container5 { get; set; }
        public string RateCode { get; set; }
        public decimal? RateUsdKg { get; set; }
        public decimal? OtherUsdKg { get; set; }
        public decimal? OtherUsdShpmnt { get; set; }
        public int? KgBooked { get; set; }
        public int? KgActual { get; set; }
        public int? KgCharged { get; set; }
        public decimal? TotalChgUsd { get; set; }
        public string Sundry1 { get; set; }
        public string Sundry2 { get; set; }

        public virtual ICollection<Cnsment> Cnsment { get; set; }
    }
}
