using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Cnsment = new HashSet<Cnsment>();
        }

        public string CrncyCode { get; set; }
        public string Currency1 { get; set; }

        public virtual ICollection<Cnsment> Cnsment { get; set; }
    }
}
