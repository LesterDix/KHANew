using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class ProdFrcst
    {
        public string SupplierId { get; set; }
        public string GrnhseId { get; set; }
        public string Cultivar { get; set; }
        public string Colour { get; set; }
        public double Hectares { get; set; }
        public int StemFcst { get; set; }
        public int Week { get; set; }
        public int Stems { get; set; }
    }
}
