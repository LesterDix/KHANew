﻿using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class CustomerBalances
    {
        public string InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string CrncyCode { get; set; }
        public decimal? InvDnValue { get; set; }
        public decimal? CnValue { get; set; }
        public DateTime? RemitDate { get; set; }
        public decimal? RemitValue { get; set; }
        public decimal? BalValue { get; set; }
        public string CstmerRemitno { get; set; }
        public decimal? RemitAmnt { get; set; }
        public decimal? Difference { get; set; }
        public string Narration { get; set; }
    }
}
