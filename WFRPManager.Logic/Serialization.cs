using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WFRPManager;
using WFRPManager.Data;

namespace WFRPManager.Logic
{
    public class Serialization
    {
        public static void ExportToJSON(Character character, string path)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(character, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json);
                sw.Close();
            }
        }
        public static Character ImportFromJSON(string path)
        {
            string json;
            using (StreamReader sr = File.OpenText(path))
            {
                json = sr.ReadToEnd();
                sr.Close();
            }
            Character character = Newtonsoft.Json.JsonConvert.DeserializeObject<Character>(json);
            _ = RemoveOldObjectsFromLists(character);
            return character;
        }

        private static async Task RemoveOldObjectsFromLists(Character character)
        {
            await Task.Run(() =>
            {
                character.Traits.RemoveRange(0, 16);
                character.Weapons.RemoveRange(0, 6);
                character.Armors.RemoveRange(0, 6);
                character.Skills.RemoveRange(0, 19);
                character.AdvancedSkills.RemoveRange(0, 14);
                character.Abilities.RemoveRange(0, 14);
                character.Items.RemoveRange(0, 13);
            });
        }
    }
}
