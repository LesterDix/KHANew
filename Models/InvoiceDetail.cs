using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class InvoiceDetail
    {
        public int TransId { get; set; }
        public int CnsmentId { get; set; }
        public string InvoiceNo { get; set; }
        public string BoeNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Sundry1 { get; set; }
        public int Week { get; set; }
        public string ProductLine { get; set; }
        public string Cultivar { get; set; }
        public string Colour { get; set; }
        public string Descript { get; set; }
        public string Cstmer { get; set; }
        public string SupplierId { get; set; }
        public string PkUnt { get; set; }
        public int PkRate { get; set; }
        public string ChgUnt { get; set; }
        public double ChgUntPkUnt { get; set; }
        public string CrncyCode { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public double NoCartons { get; set; }
        public int NoChgUnts { get; set; }
        public double NoPkUnts { get; set; }
        public decimal CrncyValue { get; set; }
        public string TransType { get; set; }
    }
}
