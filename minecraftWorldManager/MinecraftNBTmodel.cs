using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
    public class MinecraftNBTmodel
    {
        public string WorldName { get; set; }
        public bool AllowCommands { get; set; }
        public byte GameMode { get; set; }

        public bool DifficultyLocked { get; set; }
        public bool Hardcore { get; set; }
        public byte GameDifficulty { get; set; }

    }
}
