using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class CrmSummary
    {
        public int CnsmentId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Cstmer { get; set; }
        public string Cultivar { get; set; }
        public string ChgUnt { get; set; }
        public double NoCartons { get; set; }
        public double StemsCarton { get; set; }
        public int? NoStems { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public string Sundry1 { get; set; }
        public string ProductLine { get; set; }
        public string AwbNo { get; set; }
        public string SupplierId { get; set; }
    }
}
