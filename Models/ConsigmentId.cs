using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class ConsigmentId
    {
        public string InvoiceNo { get; set; }
        public string Sundry1 { get; set; }
        public string Sundry2 { get; set; }
        public int ShipId { get; set; }
        public string AwbNo { get; set; }
        public string Flight1 { get; set; }
        public string Routing { get; set; }
        public int CnsmentId { get; set; }
        public int Week { get; set; }
        public string Cstmer { get; set; }
        public string Currency { get; set; }
        public decimal ForexUsdRate { get; set; }
    }
}
