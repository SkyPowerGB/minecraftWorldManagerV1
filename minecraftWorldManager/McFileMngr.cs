using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using static System.Net.WebRequestMethods;

namespace minecraftWorldManager
{
    internal class McFileMngr
    {
        public static string CreateBranch(string worldPath, string backupsPath)
        {

            string folderName = Path.GetFileName(worldPath);

            string branchName = folderName + " Brch";
            string branchPath = Path.Combine(backupsPath, branchName);
            Directory.CreateDirectory(branchPath);
            WorldDataFileWorker.CreateBranch(branchPath);
            return branchPath;

        }


        public static void CopyWorldToRnm(string worldPath,string targetDir,string newWorldName,bool delete) {
            //prep
            string rename = newWorldName;
            if (rename == null) { rename = Path.GetFileName(worldPath); }
            string newWorldPath= Path.Combine(targetDir, rename);

            //check if exists
            if (Directory.Exists(newWorldPath)){ return; }

            //create new targetDir
            Directory.CreateDirectory(newWorldPath);

            //get all sub folders and files out
            var dirs= Directory.GetDirectories(worldPath);
            var files=Directory.GetFiles(worldPath);
          
            foreach (string file in files) {

              
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(newWorldPath, fileName);
                    System.IO.File.Copy(file, destFile, true);
                

            }

            foreach (string folder in dirs) {

                CopyWorldTo(folder,newWorldPath);
            }
            if (delete) { 
                
            Directory.Delete(worldPath,true);
            }


        }

        public static void CutWorldToRnm(string worldPath,string targetDir, string newWorldName)
        {
            CopyWorldToRnm(worldPath,targetDir,newWorldName,true);
            
        }




        public static void CopyWorldTo(string worldPath, string targetBasePath)
        {
            
            string targetDirPath = Path.Combine(targetBasePath, Path.GetFileName(worldPath));

            if (!Directory.Exists(targetDirPath))
            {
                try
                {
                    Directory.CreateDirectory(targetDirPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to create directory {targetDirPath}: {e.Message}");
                    return;
                }
            }

            
            var files = Directory.GetFiles(worldPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(targetDirPath, fileName);
                System.IO.File.Copy(file, destFile, true);
            }

            
            var directories = Directory.GetDirectories(worldPath);
            if (directories == null) { return; }
            foreach (string directory in directories)
            {
              
                CopyWorldTo(directory, targetDirPath);
            }
        }
        public static bool CutWorldTo(string worldPath, string worldPathNew)
        {
          
            try
            {

                if (!Directory.Exists(worldPath))
                {
                    Console.WriteLine($"Source directory does not exist: {worldPath}");
                    return false;
                }


                if (Directory.Exists(worldPathNew))
                {
                    Console.WriteLine($"Target directory already exists: {worldPathNew}");
                    return false;
                }


                Directory.Move(worldPath, worldPathNew);
            
                return true;
            }
            catch (IOException ioEx)
            {

                Console.WriteLine($"An I/O error occurred: {ioEx.Message}");
                return false;
            }
            catch (UnauthorizedAccessException authEx)
            {

                Console.WriteLine($"Permission error: {authEx.Message}");
                return false;
            }
            catch (Exception ex)
            {
            

                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }


        public static void CopyWorldToBackups(string worldPath, string target)
        {
            if (!WorldDataFileWorker.IsMarked(worldPath)) { return; }
            CopyWorldToBackups(worldPath, target);


        }

        private static List<DateTime> dates = new List<DateTime>();
        private static void GetAllFolderFileAvgDates(string path)
        {


            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                dates.Add(System.IO.File.GetLastWriteTime(file));
            }

            if (!Directory.GetDirectories(path).Any())
            {

                return;

            }
            var directories = Directory.GetDirectories(path);
            var filesG = Directory.GetFiles(path);



            foreach (var d in directories)
            {
                dates.Add(Directory.GetLastWriteTime(Path.Combine(path, Path.GetDirectoryName(d))));
                GetAllFolderFileAvgDates(Path.Combine(path, Path.GetDirectoryName(d)));
            }


        }

        private static DateTime CalculateAverageDate(List<DateTime> dates)
        {
            if (dates.Count == 0)
            {
                throw new InvalidOperationException("No dates to calculate average.");
            }


            long averageTicks = (long)dates.Average(date => date.Ticks);


            return new DateTime(averageTicks);
        }

        private static DateTime GetWorldAvgTime(string path)
        {

            dates.Clear();
            GetAllFolderFileAvgDates(path);
            return CalculateAverageDate(dates);

        }





    }
}
