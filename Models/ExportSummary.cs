using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class ExportSummary
    {
        public string Exporter { get; set; }
        public string SupplierId { get; set; }
        public int ExpWeek { get; set; }
        public string ExpDow { get; set; }
        public int? BnchLineId { get; set; }
        public string ChgUnt { get; set; }
        public string Cultivar { get; set; }
        public string Colour { get; set; }
        public double? TotPkUnts { get; set; }
        public int? TotChgUnts { get; set; }
    }
}
