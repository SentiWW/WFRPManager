using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFRPManager
{
    public enum TRAITNAME
    {
        WW = 1,
        US = 2,
        K = 3,
        Odp = 4,
        Zr = 5,
        Int = 6,
        SW = 7,
        Ogd = 8,
        A = 9,
        Zyw = 10,
        S = 11,
        Wt = 12,
        Sz = 13,
        Mag = 14,
        PO = 15,
        PP = 16
    };
    public class Trait
    {
        public TRAITNAME Name { get; set; }
        public int Starting { get; set; }
        public int Growth { get; set; }
        public int Actual { get; set; }

        public Trait(TRAITNAME Name)
        {
            this.Name = Name;
            this.Starting = 0;
            this.Growth = 0;
            this.Actual = 0;
        }
        public Trait(TRAITNAME Name, int Starting) : this(Name)
        {
            this.Name = Name;
            this.Starting = Starting;
            this.Growth = 0;
            this.Actual = 0;
        }
        public Trait(TRAITNAME Name, int Starting, int Growth) : this(Name, Starting)
        {
            this.Name = Name;
            this.Starting = Starting;
            this.Growth = Growth;
            this.Actual = 0;
        }
        public Trait(TRAITNAME Name, int Starting, int Growth, int Actual) : this(Name, Starting, Growth)
        {
            this.Name = Name;
            this.Starting = Starting;
            this.Growth = Growth;
            this.Actual = Actual;
        }
    }
}
