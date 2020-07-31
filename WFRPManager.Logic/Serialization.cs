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
        public static void ExportToJSON(Character character)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(character, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\debug.json"))
            {
                sw.Write(json);
                sw.Close();
            }
        }
        public static Character ImportFromJSON()
        {
            using (StreamReader sr = File.OpenText($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\debug.json"))
            {
                string json = sr.ReadToEnd();
                using (StreamWriter sw = new StreamWriter($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\debug2.json"))
                {
                    Task.Run(() => sw.Write(json));
                    sw.Close();
                }
                Character character = (Character)Newtonsoft.Json.JsonConvert.DeserializeObject<Character>(json);
                return character;
            }
        }
    }
}
