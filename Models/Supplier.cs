using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            CnsLines = new HashSet<CnsLines>();
        }

        public string SupplierId { get; set; }
        public string SupplierName { get; set; }

        public virtual ICollection<CnsLines> CnsLines { get; set; }
    }
}
