using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFCodeFirst1.EF.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }

    }
}