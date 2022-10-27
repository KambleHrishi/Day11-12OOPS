using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11OOPS
{
    public class Inventory
    {
        public List<TypesofRice> typesofRice;
        public List<TypesofPulses> typesofPulses;
        public List<TypesofWheats> typesofWheats;
    }
    public class TypesofRice
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    public class TypesofPulses
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
    public class TypesofWheats
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int price { get; set; }
    }
}
