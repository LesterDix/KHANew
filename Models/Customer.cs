﻿using System;
using System.Collections.Generic;

namespace KHANew.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Cnsment = new HashSet<Cnsment>();
        }

        public string Cstmer { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Contact { get; set; }
        public string EMail { get; set; }
        public string Landline { get; set; }
        public string Cell { get; set; }
        public string CnsgneeId { get; set; }

        public virtual ICollection<Cnsment> Cnsment { get; set; }
    }
}
