using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Product
    {
        public Product()
        {
            PrdLines = new HashSet<PrdLines>();
        }

        public string PrdId { get; set; }
        public string Descript { get; set; }

        public virtual ICollection<PrdLines> PrdLines { get; set; }
    }
}
