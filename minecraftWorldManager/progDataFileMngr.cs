using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    internal class ProgDataFileMngr
    {
        private static string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static string filePath = Path.Combine(dataFolder, "data.json");
        public static ProgramDat GetProgramData() {
            if (!File.Exists(filePath))
            {
                if (!Directory.Exists(dataFolder)) { Directory.CreateDirectory(dataFolder); }

                return new ProgramDat(); 


            }

            string json=File.ReadAllText(filePath);
            ProgramDat programData = JsonConvert.DeserializeObject<ProgramDat>(json);
            return programData;

            }
        public static void UpdateProgData(ProgramDat data) {
          

            string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);


        }



    }
}
