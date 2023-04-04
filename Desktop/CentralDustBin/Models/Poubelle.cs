using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDustBin.Models
{
    public class Poubelle
    {
        public string ID { get; set; }
        public double longt { get; set; }
        public double lat { get; set; }
        public double Capacity { get; set; }
        public double Niveau { get; set; }
    }
}
