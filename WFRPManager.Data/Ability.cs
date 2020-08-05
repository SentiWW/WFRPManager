using System;
using System.Collections.Generic;
using System.Text;

namespace WFRPManager.Data
{
    public class Ability
    {
        public string AbilityName { get; set; }
        public string AbilityDescription { get; set; }
        public Ability()
        {
            this.AbilityName = "";
            this.AbilityDescription = "";
        }
        public Ability(string AbilityName) : this() => this.AbilityName = AbilityName;
        public Ability(string AbilityName, string AbilityDescription) : this(AbilityName) => this.AbilityDescription = AbilityDescription;
    }
}
