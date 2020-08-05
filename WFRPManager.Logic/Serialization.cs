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
        private static string WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static void ExportToJSON(Character character)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(character, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter($"{WorkingDirectory}\\debug.json"))
            {
                sw.Write(json);
                sw.Close();
            }
        }
        public static Character ImportFromJSON()
        {
            using (StreamReader sr = File.OpenText($"{WorkingDirectory}\\debug.json"))
            {
                string json = sr.ReadToEnd();
                Character character = Newtonsoft.Json.JsonConvert.DeserializeObject<Character>(json);
                character.Traits.RemoveRange(0, 16);
                character.Weapons.RemoveRange(0, 6);
                character.Armors.RemoveRange(0, 6);
                return character;
            }
        }
    }
}
