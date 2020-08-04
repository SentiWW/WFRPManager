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
        private static string WorkingDirectory { get; set; }

        private static void GetWorkingDirectory()
        {
            WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
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
                using (StreamWriter sw = new StreamWriter($"{WorkingDirectory}\\debug2.json"))
                {
                    Task.Run(() => sw.Write(json));
                    sw.Close();
                }
                Character character = Newtonsoft.Json.JsonConvert.DeserializeObject<Character>(json);
                return character;
            }
        }
        public Serialization() => GetWorkingDirectory();
    }
}
