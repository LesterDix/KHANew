using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class PrdLines
    {
        public PrdLines()
        {
            CnsLines = new HashSet<CnsLines>();
        }

        public int LineId { get; set; }
        public string ProductLine { get; set; }
        public string PrdId { get; set; }
        public string Descript { get; set; }
        public string Cstmer { get; set; }
        public int? BnchLineId { get; set; }
        public string PkUnt { get; set; }
        public int? PkRate { get; set; }
        public string ChgUnt { get; set; }
        public double ChgUntPkUnt { get; set; }
        public double KgPkUnt { get; set; }
        public string CrncyCode { get; set; }
        public decimal CrncyChgUnt { get; set; }

        public virtual Product Prd { get; set; }
        public virtual ICollection<CnsLines> CnsLines { get; set; }
    }
}
