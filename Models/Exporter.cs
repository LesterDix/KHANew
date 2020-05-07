using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Exporter
    {
        public Exporter()
        {
            Cnsment = new HashSet<Cnsment>();
        }

        public string Exporter1 { get; set; }
        public string ExporterName { get; set; }

        public virtual ICollection<Cnsment> Cnsment { get; set; }
    }
}
