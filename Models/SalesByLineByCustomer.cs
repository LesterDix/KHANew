using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class SalesByLineByCustomer
    {
        public int CnsmentId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Sundry1 { get; set; }
        public string Year { get; set; }
        public int Week { get; set; }
        public string Exporter { get; set; }
        public int ShipId { get; set; }
        public string ProductLine { get; set; }
        public double NoPkUnts { get; set; }
        public string PkUnt { get; set; }
        public double ChgUntPkUnt { get; set; }
        public int TotalStems { get; set; }
        public string ChgUnt { get; set; }
        public double KgPkUnt { get; set; }
        public string CrncyCode { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public decimal ForexUsdRate { get; set; }
        public double? CrncyValue { get; set; }
        public double? UsdVal { get; set; }
        public string Cultivar { get; set; }
        public string Colour { get; set; }
        public string SupplierId { get; set; }
        public string Descript { get; set; }
        public double KgNet { get; set; }
        public double CnTotalStems { get; set; }
        public decimal CnValue { get; set; }
        public double NetStems { get; set; }
        public double? NetCrncyValue { get; set; }
        public double? NetUsdValue { get; set; }
        public int? TransId { get; set; }
        public string TransType { get; set; }
        public string PrdId { get; set; }
        public double NoCartons { get; set; }
        public string BoeNo { get; set; }
        public double? ActKg { get; set; }
        public string Cstmer { get; set; }
        public decimal? RateCrncyStem { get; set; }
        public decimal? CifCrncyChgUnt { get; set; }
    }
}
