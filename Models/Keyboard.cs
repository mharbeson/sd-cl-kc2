using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Models
{
    internal class Keyboard : Peripheral
    {
        public string Size { get; set; }

        public string Color { get; set; }

        public bool HasNumberPad { get; set; }

        public bool HasRGB { get; set; }
    }
}
