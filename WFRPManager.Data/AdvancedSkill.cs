using System;
using System.Collections.Generic;
using System.Text;

namespace WFRPManager.Data
{
    public class AdvancedSkill : Skill
    {
        public string AdvancedSkillName { get; set; }
        public AdvancedSkill() : base() { }
        public AdvancedSkill(string ConnectedSkill) : base(ConnectedSkill) { }
        public AdvancedSkill(string ConnectedSkill, bool Skill1) : base(ConnectedSkill, Skill1) { }
        public AdvancedSkill(string ConnectedSkill, bool Skill1, bool Skill2) : base(ConnectedSkill, Skill1, Skill2) { }
        public AdvancedSkill(string ConnectedSkill, bool Skill1, bool Skill2, bool Skill3) : base(ConnectedSkill, Skill1, Skill2, Skill3) { }
        public AdvancedSkill(string ConnectedSkill, bool Skill1, bool Skill2, bool Skill3, string AdvancedSkillName) : this(ConnectedSkill, Skill1, Skill2, Skill3) => this.AdvancedSkillName = AdvancedSkillName;
    }
}