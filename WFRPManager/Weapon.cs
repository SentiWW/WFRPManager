using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFRPManager
{
    public class Weapon
    {
        public string Name { get; set; }
        public string Weight { get; set; }
        public string Category { get; set; }
        public string Strength { get; set; }
        public string Range { get; set; }
        public string Reload { get; set; }
        public string Traits { get; set; }

        public Weapon()
        {
            this.Name = "";
            this.Weight = "";
            this.Category = "";
            this.Strength = "";
            this.Range = "";
            this.Reload = "";
            this.Traits = "";
        }
        public Weapon(string Name) : this()
        {
            this.Name = Name;
            this.Weight = "?";
            this.Category = "?";
            this.Strength = "?";
            this.Range = "?";
            this.Reload = "?";
            this.Traits = "?";

        }
        public Weapon(string Name, string Strength) : this(Name)
        {
            this.Name = Name;
            this.Weight = "?";
            this.Category = "?";
            this.Strength = Strength;
            this.Range = "?";
            this.Reload = "?";
            this.Traits = "?";
        }
        public Weapon(string Name, string Strength, string Range) : this(Name, Strength)
        {
            this.Name = Name;
            this.Weight = "?";
            this.Category = "?";
            this.Strength = Strength;
            this.Range = Range;
            this.Reload = "?";
            this.Traits = "?";
        }
        public Weapon(string Name, string Strength, string Range, string Reload) : this(Name, Strength, Range)
        {
            this.Name = Name;
            this.Weight = "?";
            this.Category = "?";
            this.Strength = Strength;
            this.Range = Range;
            this.Reload = Reload;
            this.Traits = "?";
        }
        public Weapon(string Name, string Strength, string Range, string Reload, string Category) : this(Name, Strength, Range, Reload)
        {
            this.Name = Name;
            this.Weight = "?";
            this.Category = Category;
            this.Strength = Strength;
            this.Range = Range;
            this.Reload = Reload;
            this.Traits = "?";
        }
        public Weapon(string Name, string Strength, string Range, string Reload, string Category, string Traits) : this(Name, Strength, Range, Reload, Category)
        {
            this.Name = Name;
            this.Weight = "?";
            this.Category = Category;
            this.Strength = Strength;
            this.Range = Range;
            this.Reload = Reload;
            this.Traits = Traits;
        }
        public Weapon(string Name, string Strength, string Range, string Reload, string Category, string Traits, string Weight) : this(Name, Strength, Range, Reload, Category, Traits)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.Category = Category;
            this.Strength = Strength;
            this.Range = Range;
            this.Reload = Reload;
            this.Traits = Traits;
        }
    }
}
