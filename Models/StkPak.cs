using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class StkPak
    {
        public string PakId { get; set; }
        public string Descript { get; set; }
        public string Supplier { get; set; }
        public int? OpnNo { get; set; }
        public decimal? OpnUsd { get; set; }
        public int? InNo { get; set; }
        public decimal? InUsd { get; set; }
        public int? OutNo { get; set; }
        public decimal? OutUsd { get; set; }
        public int? BalNo { get; set; }
        public decimal? BalUsd { get; set; }
        public DateTime? DatePhys { get; set; }
    }
}
