using System;
using System.Collections.Generic;
using System.Text;

namespace ef_gardening.Models
{
    class Region
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
