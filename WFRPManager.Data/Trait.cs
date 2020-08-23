using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFRPManager.Data
{
    public enum TRAITNAME
    {
        WW = 0,
        US = 1,
        K = 2,
        Odp = 3,
        Zr = 4,
        Int = 5,
        SW = 6,
        Ogd = 7,
        A = 8,
        Zyw = 9,
        S = 10,
        Wt = 11,
        Sz = 12,
        Mag = 13,
        PO = 14,
        PP = 15,
        NULL = 16
    };
    public class Trait
    {
        public TRAITNAME Name { get; set; }
        public int Starting { get; set; }
        public int Growth { get; set; }
        public int Actual { get; set; }

        public Trait()
        {
            this.Name = TRAITNAME.NULL;
            this.Starting = 0;
            this.Growth = 0;
            this.Actual = 0;
        }
        public Trait(TRAITNAME Name) : this()
        {
            this.Name = Name;
            this.Starting = 0;
            this.Growth = 0;
            this.Actual = 0;
        }
        public Trait(TRAITNAME Name, int Starting) : this(Name) => this.Starting = Starting;
        public Trait(TRAITNAME Name, int Starting, int Growth) : this(Name, Starting) => this.Growth = Growth;
        public Trait(TRAITNAME Name, int Starting, int Growth, int Actual) : this(Name, Starting, Growth) => this.Actual = Actual;
    }
}
