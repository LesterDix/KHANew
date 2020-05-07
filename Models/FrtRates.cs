using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class FrtRates
    {
        public int RateId { get; set; }
        public string Descript { get; set; }
        public string DestCode { get; set; }
        public string DepDow { get; set; }
        public string FrtRateCode1 { get; set; }
        public string FrtRateCode2 { get; set; }
        public string Flight1 { get; set; }
        public string Flight2 { get; set; }
        public string Flight3 { get; set; }
        public string Routing { get; set; }
        public string RateUsdKg { get; set; }
        public string SdryUsdKg { get; set; }
    }
}
