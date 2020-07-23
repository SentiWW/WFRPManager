using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFRPManager
{
    public enum ARMOR { SIMPLE, ADVANCED };
    public class Armor
    {
        public ARMOR Complexity { get; set; }
        public string Type { get; set; }
        public string Weight { get; set; }
        public string Location { get; set; }
        public string PZ { get; set; }

        public Armor()
        {

        }

    }
}
