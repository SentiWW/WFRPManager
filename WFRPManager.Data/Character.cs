﻿using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace WFRPManager.Data
{
    public class Character
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string CurrentRole { get; set; }
        public string PreviousRole { get; set; }
        public string Age { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string StarSign { get; set; }
        public string Birthplace { get; set; }
        public string Features { get; set; }
        public string Sex { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Siblings { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }
        public string LeftArm { get; set; }
        public string RightArm { get; set; }
        public string LeftLeg { get; set; }
        public string RightLeg { get; set; }
        public string CurrentXP { get; set; }
        public string TotalXP { get; set; }
        public string MovementRetreat { get; set; }
        public string Charge { get; set; }
        public string Sprint { get; set; }
        public int MoneyZK { get; set; }
        public int MoneyS { get; set; }
        public int MoneyP { get; set; }
        public List<Trait> Traits { get; set; }
        public List<Weapon> Weapons { get; set; }
        public SimpleArmor SArmor { get; set; }
        public List<AdvancedArmor> Armors { get; set; }
        public List<Skill> Skills { get; set; }
        public List<AdvancedSkill> AdvancedSkills { get; set; }
        public List<Ability> Abilities { get; set; }
        public List<Item> Items { get; set; }
 
#if DEBUG
        public void Debug()
        {
            using(StreamWriter sw = new StreamWriter($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\debug_log.txt"))
            {
                sw.WriteLine($"Name: {Name}\nRace: {Race}\nCurrentRole: {CurrentRole}\nPreviousRole: {PreviousRole}\nAge: {Age}\nEyeColor: {EyeColor}\n" +
                $"HairColor: {HairColor}\nStarSign: {StarSign}\nBirthplace: {Birthplace}\nFeatures: {Features}\nSex: {Sex}\nWeight: {Weight}\nHeight: {Height}\n" +
                $"Siblings: {Siblings}\nHead: {Head}\nBody: {Body}\nLeftArm: {LeftArm}\nRightArm: {RightArm}\nLeftLeg: {LeftLeg}\nRightLeg: {RightLeg}\n" +
                $"CurrentXP: {CurrentXP}\nTotalXP: {TotalXP}\nMovementRetreat: {MovementRetreat}\nCharge: {Charge}\nSprint: {Sprint}\n\n");
                sw.Close();
            }
        }
#endif

        public Character()
        {
            Traits = new List<Trait>()
            {
                new Trait(TRAITNAME.WW),
                new Trait(TRAITNAME.US),
                new Trait(TRAITNAME.K),
                new Trait(TRAITNAME.Odp),
                new Trait(TRAITNAME.Zr),
                new Trait(TRAITNAME.Int),
                new Trait(TRAITNAME.SW),
                new Trait(TRAITNAME.Ogd),
                new Trait(TRAITNAME.A),
                new Trait(TRAITNAME.Zyw),
                new Trait(TRAITNAME.S),
                new Trait(TRAITNAME.Wt),
                new Trait(TRAITNAME.Sz),
                new Trait(TRAITNAME.Mag),
                new Trait(TRAITNAME.PO),
                new Trait(TRAITNAME.PP)
            };

            Weapons = new List<Weapon>()
            {
                new Weapon(),
                new Weapon(),
                new Weapon(),
                new Weapon(),
                new Weapon(),
                new Weapon()
            };

            SArmor = new SimpleArmor();

            Armors = new List<AdvancedArmor>()
            {
                new AdvancedArmor(),
                new AdvancedArmor(),
                new AdvancedArmor(),
                new AdvancedArmor(),
                new AdvancedArmor(),
                new AdvancedArmor()
            };

            Skills = new List<Skill>()
            {
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill(),
                new Skill()
            };

            AdvancedSkills = new List<AdvancedSkill>()
            {
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill(),
                new AdvancedSkill()
            };

            Abilities = new List<Ability>()
            {
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability()
            };

            Items = new List<Item>()
            {
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item(),
                new Item()
            };
        }
    }
}
