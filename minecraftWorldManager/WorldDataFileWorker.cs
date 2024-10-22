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

      
        public static void MarkWorld(String worldPath,String mCversion,String worldVersion ) {
            if (IsMarked(worldPath)) { return; }
            WorldDataFile file = new WorldDataFile(mCversion,worldVersion);

            String filePath=Path.Combine(worldPath,fileName);

            String json=JsonConvert.SerializeObject(file,Formatting.Indented);
            File.WriteAllText(filePath, json);

        }

        public static void CreateBranch(String location) { 
           if(IsBranch(location)) { return; }
           if(IsMarked(location)) { return; }
            BranchFlag flag = new BranchFlag();
            flag.Branch = true;


            String json = JsonConvert.SerializeObject(flag, Formatting.Indented);
            File.WriteAllText(Path.Combine(location,branchName), json);




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
            string filePath =Path.Combine(Path.GetDirectoryName(path), fileName);
            if (!File.Exists(filePath)) { return null; }
         
            string json=File.ReadAllText(filePath);
            WorldDataFile file=JsonConvert.DeserializeObject<WorldDataFile>(json);
            return file;
     
        }

        public static void UpdateWorldDF(WorldDataFile worldDataFile, string path)
        {

            string updatedJson = JsonConvert.SerializeObject(worldDataFile, Formatting.Indented);
            File.WriteAllText(path, updatedJson);
        }
        




    
    
    }


}
