using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    public class WorldDataFile
    {

        public WorldDataFile() { }
        public WorldDataFile(string minecraftVersion, string worldVersion)
        {
            this.worldVersion = minecraftVersion;
            this.minecraftVersion = worldVersion;
            this.marked = DateTime.Now;

        }

        public string worldVersion;
        public string minecraftVersion;
        public DateTime marked;

        public DateTime saveDate;

       

    }
}
