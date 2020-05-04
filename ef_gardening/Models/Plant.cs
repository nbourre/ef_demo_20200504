using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ef_gardening.Models
{
    class Plant
    {
        public int PlantID { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public double Height { get; set; }

        public Family Family { get; set; }
        public Region Region { get; set; }

        public override string ToString()
        {
            return CommonName;
        }
    }
}
