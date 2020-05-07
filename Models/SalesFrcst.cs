using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class SalesFrcst
    {
        public int TransId { get; set; }
        public int Week { get; set; }
        public int LineId { get; set; }
        public string ProductLine { get; set; }
        public string PrdId { get; set; }
        public string Cstmer { get; set; }
        public string ChgUnt { get; set; }
        public int NoChgUnt { get; set; }
    }
}
