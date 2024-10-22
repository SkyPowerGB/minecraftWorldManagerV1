using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    internal class WorldDataFile
    {


        public WorldDataFile(string minecraftVersion, string worldVersion)
        {
            this.worldVersion = minecraftVersion;
            this.minecraftVersion = worldVersion;
            this.marked = DateTime.Now;

        }

        private string worldVersion;
        private string minecraftVersion;
        private DateTime marked;
      
        private DateTime saveDate;

       

    }
}
