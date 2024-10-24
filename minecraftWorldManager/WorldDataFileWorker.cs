using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    internal class WorldDataFileWorker
    {

        public WorldDataFileWorker() { }

       static private string fileName = "WorldDataFile.json";
       static private string branchName = "BranchFlag.json";

        private static string GetWorldDFfilePath(string worldPath) { return Path.Combine(worldPath, fileName); }
        public static void MarkWorld(String worldPath,WorldDataFile file) {
            if (IsMarked(worldPath)) { UpdateWorldDF(file, worldPath); return; }
            MarkWorld(worldPath, file.minecraftVersion, file.worldVersion);
        }
        public static void MarkWorld(String worldPath,String mCversion,String worldVersion ) {
            if (IsMarked(worldPath)) { return; }
            WorldDataFile file = new WorldDataFile(mCversion,worldVersion);
            file.saveDate = DateTime.Now;
            String filePath=Path.Combine(worldPath,fileName);
             
            String json=JsonConvert.SerializeObject(file,Formatting.Indented);
            File.WriteAllText(filePath, json);

        }

        public static string CreateBranch(String location) { 
           if(IsBranch(location)) { return ""; }
           if(IsMarked(location)) { return ""; }
            BranchFlag flag = new BranchFlag();
            flag.Branch = true;

            string flagPath = Path.Combine(location, branchName);
            String json = JsonConvert.SerializeObject(flag, Formatting.Indented);
            File.WriteAllText(flagPath, json);



            return flagPath;
        }

        public static bool IsBranch(String path) { 
            if(File.Exists(Path.Combine(path, branchName)))
            {
                return true;
            }
            
            return false; }

        public static bool IsMarked(String path)
        {
            if (File.Exists(Path.Combine(path, fileName)))
            {
                return true;
            }

            return false;
        }
  
        public static WorldDataFile GetWroldDF(string path) {
            if (path == null) { return null; }
            string filePath =Path.Combine(path, fileName);
            if (!File.Exists(filePath)) { return null; }
        

            string json=File.ReadAllText(filePath);
            WorldDataFile file=JsonConvert.DeserializeObject<WorldDataFile>(json);
            Console.WriteLine("world version get file:"+ file.worldVersion);
            return file;
     
        }

        public static void UpdateWorldDF(WorldDataFile worldDataFile, string worldPath)
        {
           string filePath=GetWorldDFfilePath(worldPath);
          
              worldDataFile.saveDate = DateTime.Now;
            string updatedJson = JsonConvert.SerializeObject(worldDataFile, Formatting.Indented);
            File.WriteAllText(filePath, updatedJson);
        }
        




    
    
    }


}
