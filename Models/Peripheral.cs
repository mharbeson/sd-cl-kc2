using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    internal class Peripheral : Product
    {
        public string Type { get; set; }

        public string ConnectionType { get; set; }
    }
}
