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
           
            string rename = newWorldName;
            if (rename == null) { rename = Path.GetFileName(worldPath); }
            string newWorldPath= Path.Combine(targetDir, rename);

          
            if (Directory.Exists(newWorldPath)){ 
                FolderExistsErrorForm folderExistsDialog=new FolderExistsErrorForm(worldPath,newWorldPath);
                folderExistsDialog.ShowDialog();
                if (folderExistsDialog.result == FolderExistsErrorForm.CANCEL) { return; }
                else if (folderExistsDialog.result == FolderExistsErrorForm.OVERWRITE) { }
                else if (folderExistsDialog.result == FolderExistsErrorForm.RENAME)
                {
                    CopyWorldToRnm(worldPath,targetDir,folderExistsDialog.NewName,false);

                    return;
                }
                
                
               }

            
            Directory.CreateDirectory(newWorldPath);

            
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

            CopyWorldTo(worldPath,targetBasePath,true);
        }

        public static void CopyWorldTo(string worldPath, string targetBasePath,bool overWrite)
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
            } else if (Directory.Exists(targetDirPath)&&!overWrite) {
                FolderExistsErrorForm folderExists = new FolderExistsErrorForm(worldPath,targetDirPath);
                folderExists.ShowDialog();
                var result=folderExists.result;
                if (result == FolderExistsErrorForm.RENAME)
                {
                    targetDirPath = Path.Combine(targetBasePath, folderExists.NewName);
                    CopyWorldToRnm(worldPath,targetBasePath,folderExists.NewName,false);
                        return;
                }
                else if (result == FolderExistsErrorForm.OVERWRITE)
                {
                    CopyWorldTo(worldPath, targetBasePath,true);
                }
                else if (result == FolderExistsErrorForm.CANCEL) {

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

                CopyWorldTo(directory, targetDirPath,true);
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
                   

                    FolderExistsErrorForm folderExists = new FolderExistsErrorForm(worldPath, worldPathNew);
                    folderExists.ShowDialog();
                    if (folderExists.result == FolderExistsErrorForm.RENAME)
                    {

                        var targetParent = Path.GetDirectoryName(worldPathNew);
                        var newTargetPath = Path.Combine(targetParent, folderExists.NewName);
                        CutWorldTo(worldPath, newTargetPath);


                    } else if (
                        folderExists.result == FolderExistsErrorForm.OVERWRITE ) {
                        CopyWorldTo(worldPath,Path.GetDirectoryName(worldPathNew));
                        Directory.Delete(worldPath,true);
                    }
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
        public static void RenameWorld(string baseDirectory,string worldPath, string newName) {
                         string newPath=Path.Combine(baseDirectory, newName);
            try
            {
              
                Directory.Move(worldPath, newPath);

               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public static void CopyWorldToBackups(string worldPath, string target)
        {
            if (!WorldDataFileWorker.IsMarked(worldPath)) { return; }
            CopyWorldToBackups(worldPath, target);


        }

        public static void CopyAllSubdirsTo(string sourceDirPath , string destinationPath) {
                    if(sourceDirPath == null ) {
                Console.WriteLine("copy failed source not found" );
                return; }
            if (destinationPath == null) {
                Console.WriteLine("copy failed target not found");
                return;
            }

            var dirs=Directory.GetDirectories(sourceDirPath);
            foreach (var dir in dirs) {
                Console.WriteLine("try copy" + dir);
                CopyWorldTo(dir, destinationPath,false);
            
            }

        }

        private static List<DateTime> dates = new List<DateTime>();
       




    }
}
