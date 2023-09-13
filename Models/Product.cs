using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    internal class Product
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int QuantityInStock { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
