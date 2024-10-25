using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    public class WorldDataFile
    {

        public WorldDataFile() {
            this.marked = DateTime.Now;
        }
        public WorldDataFile(string minecraftVersion, string worldVersion)
        {
            this.worldVersion = worldVersion;
            this.minecraftVersion = minecraftVersion;
            this.marked = DateTime.Now;

        }
        public string Description { get; set; }
        public string worldVersion;
        public string minecraftVersion;
        public DateTime? marked;

        public DateTime? saveDate;

       

    }
}
