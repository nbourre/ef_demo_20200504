using System;
using System.Collections.Generic;
using System.Text;

namespace ef_gardening.Models
{
    class Family
    {
        public int FamilyID { get; set; }
        public string Name { get; set; }

        public override string ToString() => Name;
    }
}
