using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class CustomerRemitValue
    {
        public string CstmerRemitno { get; set; }
        public DateTime? RemitDate { get; set; }
        public string Cstmer { get; set; }
        public string CrncyCode { get; set; }
        public decimal? TotRemit { get; set; }
    }
}
