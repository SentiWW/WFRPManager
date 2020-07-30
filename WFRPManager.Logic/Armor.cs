using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFRPManager.Logic
{
    public class SimpleArmor
    {
        public string Type { get; set; }
        public string PZ { get; set; }

        public SimpleArmor()
        {
            this.Type = "";
            this.PZ = "";
        }
        public SimpleArmor(string Type) : this() => this.Type = Type;
        public SimpleArmor(string Type, string PZ) : this(Type) => this.PZ = PZ;

    }
    public class AdvancedArmor : SimpleArmor
    {
        public string Weight { get; set; }
        public string Location { get; set; }

        public AdvancedArmor() : base() { }
        public AdvancedArmor(string Type) : base(Type) { }
        public AdvancedArmor(string Type, string PZ) : base(Type, PZ) { }
        public AdvancedArmor(string Type, string PZ, string Location) : base(Type, PZ) => this.Location = Location;
        public AdvancedArmor(string Type, string PZ, string Location, string Weight) : this(Type, PZ, Location) => this.Weight = Weight;
    }
}
