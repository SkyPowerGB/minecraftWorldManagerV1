using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    internal class QbckpFileMngr
    {
        private static string dataFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
        private static string filePath = Path.Combine(dataFolder, "qBckpData.json");
        public static QuickBackupsDat GetQuickBckpData()
        {
            if (!File.Exists(filePath))
            {
                return null;


            }

            string json = File.ReadAllText(filePath);
            QuickBackupsDat programData = JsonConvert.DeserializeObject<QuickBackupsDat>(json);
            return programData;

        }
        public static void UpdateQbckpData(QuickBackupsDat data)
        {


            string updatedJson = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);


        }


    }
}
