using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFRPManager
{
    class Character
    {
        private string Name { get; set; }
        private string Race { get; set; }
        private string CurrentRole { get; set; }
        private string PreviousRole { get; set; }
        private string Age { get; set; }
        private string EyeColor { get; set; }
        private string HairColor { get; set; }
        private string StarSign { get; set; }
        private string Birthplace { get; set; }
        private string Features { get; set; }
        private string Sex { get; set; }
        private string Weight { get; set; }
        private string Height { get; set; }
        private string Siblings { get; set; }
        private List<int> MainTraits = new List<int>();
        private List<int> SecondaryTraits = new List<int>();
        private List<Weapon> Weapons = new List<Weapon>();
        private List<Armor> Armors = new List<Armor>();
    }
}
