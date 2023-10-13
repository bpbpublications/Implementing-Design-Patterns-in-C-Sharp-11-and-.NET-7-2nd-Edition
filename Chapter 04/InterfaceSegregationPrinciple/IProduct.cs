using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_04.InterfaceSegregationPrinciple
{
    interface IProduct
    {
        public string ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
    }
}
