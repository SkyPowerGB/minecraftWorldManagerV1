using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    public class AutoBackuper
    {
        private string qBackupsFolderPath;
        private string mcWorldsPath;
        public async Task BackupAsync(string qBackupsFolderPath,string mcWorldsPath) { 
            this.qBackupsFolderPath = qBackupsFolderPath; 
            this.mcWorldsPath= mcWorldsPath;

            while (true)
            {
                var data = QbckpFileMngr.GetQuickBckpData();
                if (data != null)
                {
                    var time = DateTime.Now;
                    var saveTimeB = data.lastBackup.AddDays(data.numDays).AddHours(data.numHours).AddMinutes(data.numMinute);
                    
                        var dirPath = Path.Combine(qBackupsFolderPath, data.folderName);
                    if (time >= saveTimeB)
                    {
                        if (!Directory.Exists(dirPath))
                        {
                            Directory.CreateDirectory(dirPath);

                        }
                        Console.WriteLine("backup" + mcWorldsPath);
                        McFileMngr.CopyAllSubdirsTo(mcWorldsPath, dirPath, true);

                        data.lastBackup = DateTime.Now;
                        QbckpFileMngr.UpdateQbckpData(data);

                    }
                    
                }



                await Task.Delay(60000);
            }




      
        
        }
    }
}
