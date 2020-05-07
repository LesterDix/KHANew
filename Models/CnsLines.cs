using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class CnsLines
    {
        public CnsLines()
        {
            CreditDetails = new HashSet<CreditDetails>();
            Remittances = new HashSet<Remittances>();
        }

        public int TransId { get; set; }
        public int CnsmentId { get; set; }
        public int LineId { get; set; }
        public string ProductLine { get; set; }
        public string Descript { get; set; }
        public int? BnchLineId { get; set; }
        public string Cstmer { get; set; }
        public string PkUnt { get; set; }
        public int PkRate { get; set; }
        public string ChgUnt { get; set; }
        public double ChgUntPkUnt { get; set; }
        public double KgPkUnt { get; set; }
        public string CrncyCode { get; set; }
        public decimal CrncyChgUnt { get; set; }
        public double NoPkUnts { get; set; }
        public double NoCartons { get; set; }
        public string Cultivar { get; set; }
        public string Colour { get; set; }
        public string SupplierId { get; set; }
        public int? PkWeek { get; set; }
        public string PkDow { get; set; }
        public int NoChgUnts { get; set; }
        public decimal? CrncyValue { get; set; }
        public string TransType { get; set; }
        public decimal? FrtChgUnt { get; set; }

        public virtual Cnsment Cnsment { get; set; }
        public virtual PrdLines Line { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<CreditDetails> CreditDetails { get; set; }
        public virtual ICollection<Remittances> Remittances { get; set; }
    }
}
