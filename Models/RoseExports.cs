using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class RoseExports
    {
        public DateTime InvoiceDate { get; set; }
        public int Week { get; set; }
        public string Exporter { get; set; }
        public int TotalStems { get; set; }
        public string CrncyCode { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public double? CrncyValue { get; set; }
        public double? UsdVal { get; set; }
        public string Cultivar { get; set; }
        public string SupplierId { get; set; }
        public string ChgUnt { get; set; }
        public double? NetCrncyValue { get; set; }
        public double? NetUsdValue { get; set; }
        public string Cstmer { get; set; }
        public decimal? RateCrncyStem { get; set; }
    }
}
