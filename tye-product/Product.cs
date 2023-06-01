using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tye_product
{
    public record Product {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
    public record Customer {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}