using System;
using System.Collections.Generic;
using System.Text;

namespace WFRPManager.Data
{
    public class Skill
    {
        public bool Skill1 { get; set; }
        public bool Skill2 { get; set; }
        public bool Skill3 { get; set; }
        public string ConnectedSkill { get; set; }

        public void CascadeTraitAssign()
        {
            if (Skill3) Skill2 = true;
            if (Skill2) Skill1 = true;
        }

        public Skill()
        {
            Skill1 = false;
            Skill2 = false;
            Skill3 = false;
            ConnectedSkill = "";
        }
        public Skill(string ConnectedSkill) : this() => this.ConnectedSkill = ConnectedSkill;
        public Skill(string ConnectedSkill, bool Skill1) : this(ConnectedSkill) => this.Skill1 = Skill1;
        public Skill(string ConnectedSkill, bool Skill1, bool Skill2) : this(ConnectedSkill, Skill1) => this.Skill2 = Skill2;
        public Skill(string ConnectedSkill, bool Skill1, bool Skill2, bool Skill3) : this(ConnectedSkill, Skill1, Skill2) => this.Skill3 = Skill3;
    }
}
