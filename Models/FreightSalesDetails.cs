using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FreightSalesDetails
    {
        public string InvoiceNo { get; set; }
        public DateTime? ShipDate { get; set; }
        public string Cstmer { get; set; }
        public int Week { get; set; }
        public string FreightInvoice { get; set; }
        public string AwbNo { get; set; }
        public string Flight1 { get; set; }
        public decimal? FrtChgUsd { get; set; }
    }
}
