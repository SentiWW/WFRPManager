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
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(character, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\debug.json"))
            {
                Task.Run(() => sw.Write(json));
                sw.Close();
            }
        }
        public static async Task ImportFromJSON()
        {

        }
    }
}
