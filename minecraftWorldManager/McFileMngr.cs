using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.WebRequestMethods;

namespace minecraftWorldManager
{
    internal class McFileMngr
    {
        public string CreateBranch(string worldPath,string backupsPath) {
        
            string folderName=  Path.GetDirectoryName(worldPath);

            string branchName = folderName + "_Branch";
            string branchPath = Path.Combine(backupsPath, branchName);
           Directory.CreateDirectory(branchPath);
            return branchPath; 
        
        }

        public void CopyWorldTo(string worldPath, string target)
        {
         
            string targetDirPath = Path.Combine(target, Path.GetFileName(worldPath));


            if (!Directory.Exists(targetDirPath))
            {
                Directory.CreateDirectory(targetDirPath);
            }
            else {
                return;
            }

           
            var files = Directory.GetFiles(worldPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDirPath, fileName);
                System.IO.File.Copy(file, destFile, true); 
            }

         
            var directories = Directory.GetDirectories(worldPath);
            foreach (string directory in directories)
            {
                string directoryName = Path.GetFileName(directory);
                string targetSubDir = Path.Combine(targetDirPath, directoryName);
                CopyWorldTo(directory, targetSubDir); 
            }

        }

        public void CutWorldTo(string worldPath, string target) { 
           CopyWorldTo(worldPath, target);

            Directory.Delete(worldPath);
        
        
        }

        public void CopyWorldToBackups(string worldPath, string target) {
            if (!WorldDataFileWorker.IsMarked(worldPath)) { return; }
            CopyWorldToBackups(worldPath, target);

        
        }

       private static List<DateTime> dates = new List<DateTime>();
        private void GetAllFolderFileAvgDates(string path) {


            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                dates.Add(System.IO.File.GetLastWriteTime(file));
            }

            if (!Directory.GetDirectories(path).Any()) {
          
                return;
            
            }
            var directories = Directory.GetDirectories(path);
            var filesG = Directory.GetFiles(path);
          


            foreach (var d in directories) {
                 dates.Add(Directory.GetLastWriteTime(Path.Combine(path, Path.GetDirectoryName(d))));
                GetAllFolderFileAvgDates(Path.Combine(path,Path.GetDirectoryName(d)));
            }


        }

        static DateTime CalculateAverageDate(List<DateTime> dates)
        {
            if (dates.Count == 0)
            {
                throw new InvalidOperationException("No dates to calculate average.");
            }

           
            long averageTicks = (long)dates.Average(date => date.Ticks);

         
            return new DateTime(averageTicks);
        }

        private DateTime GetWorldAvgTime(string path) {
           
            dates.Clear();
            GetAllFolderFileAvgDates(path);
            return CalculateAverageDate(dates);
        
        }





    }
}
