using fNbt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace minecraftWorldManager
{
 
    public class MinecraftNBTfileManager
    {
      
        private static string NBTfile = "level.dat";

        private static string GameModeTagName = "GameType";
        private static string HardcoreModeTagName = "hardcore";
        private static string AllowCheatsTagName = "allowCommands";
        private static string DifficultyLockedTagName = "DifficultyLocked";
        private static string DifficultyTagName = "Difficulty";
        private static string WorldNameTagName = "LevelName";
        private static string WorldVersionTagName = "Name";


        public static MinecraftNBTmodel ReadMcNBTfile(string worldPath)
        {
            MinecraftNBTmodel model = new MinecraftNBTmodel();
            string path = getNbtFilePath(worldPath);

            if (!File.Exists(path))
            {
                Console.WriteLine($"File does not exist: {path}");
                return null;
            }

            try
            {
                using (FileStream fileStream = File.OpenRead(path))
                {
                    NbtFile nbtFile = new NbtFile();
                    nbtFile.LoadFromStream(fileStream, NbtCompression.AutoDetect);

                    NbtCompound rootTag = nbtFile.RootTag;
                    NbtCompound levelData = rootTag.Get<NbtCompound>("Data");


                    NbtCompound VersionTag = levelData.Get<NbtCompound>("Version");
                    if(VersionTag!= null)
                    {
                        if (VersionTag.Get(WorldVersionTagName) is NbtString versionString)
                        {
                            if (versionString.HasValue)
                            {
                                model.WorldVersion = versionString.Value;
                            }
                        }

                    }

                    if (levelData != null)
                    {

                        if (levelData.Get(HardcoreModeTagName) is NbtByte hardcoreTag)
                        {
                            model.Hardcore = hardcoreTag.ByteValue == 1;
                        }


                        if (levelData.Get(GameModeTagName) is NbtInt gameModeTag)
                        {
                            if (!model.Hardcore)
                            {
                                model.GameMode = (byte)gameModeTag.IntValue;

                            }
                            else
                            {
                                model.GameMode = 4;
                            }
                        }

                     
                       
                     
                        if (levelData.Get(WorldNameTagName) is NbtString worldNameTag)
                        {
                            model.WorldName = worldNameTag.StringValue;
                        }

                       
                        if (levelData.Get(DifficultyLockedTagName) is NbtByte difficultyLockedTag)
                        {
                            model.DifficultyLocked = difficultyLockedTag.ByteValue != 0;
                        }

                       
                        if (levelData.Get(AllowCheatsTagName) is NbtByte allowCommandsTag)
                        {
                            model.AllowCommands = allowCommandsTag.ByteValue != 0;
                        }

                        
                        if (levelData.Get(DifficultyTagName) is NbtInt difficultyTag)
                        {
                            model.GameDifficulty = (byte)difficultyTag.IntValue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Level data not found in NBT file.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the NBT file: " + ex.Message);
            }

            return model;
        }

        public static void UpdateMcNBTfile(string worldPath, MinecraftNBTmodel model)
        {
            string path = getNbtFilePath(worldPath);

            if (!File.Exists(path))
            {
                Console.WriteLine($"File does not exist: {path}");
                return;
            }

            try
            {
                NbtFile nbtFile = new NbtFile();

                
                using (FileStream fileStream = File.OpenRead(path))
                {
                    nbtFile.LoadFromStream(fileStream, NbtCompression.AutoDetect);
                }

                NbtCompound rootTag = nbtFile.RootTag;
                NbtCompound levelData = rootTag.Get<NbtCompound>("Data");

              
                if (levelData != null)
                {
                    // Update NBT tags
                    levelData[GameModeTagName] = new NbtInt(GameModeTagName, model.GameMode);
                    levelData[HardcoreModeTagName] = new NbtByte(HardcoreModeTagName, model.Hardcore ? (byte)1 : (byte)0);
                    levelData[WorldNameTagName] = new NbtString(WorldNameTagName, model.WorldName);
                    levelData[AllowCheatsTagName] = new NbtByte(AllowCheatsTagName, model.AllowCommands ? (byte)1 : (byte)0);
                    levelData[DifficultyLockedTagName] = new NbtByte(DifficultyLockedTagName, model.DifficultyLocked ? (byte)1 : (byte)0);
                    levelData[DifficultyTagName] = new NbtInt(DifficultyTagName, model.GameDifficulty);

                    // Save the NBT file with explicit compression
                    using (FileStream writeStream = File.Open(path, FileMode.Create))
                    {
                        nbtFile.SaveToStream(writeStream, NbtCompression.GZip); // Specify the compression type
                        Console.WriteLine("NBT data updated successfully.");
                    }
                }
                else
                {
                    Console.WriteLine("Level data not found in NBT file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the NBT file: " + ex.Message);
            }
        }

        public static void UpdateMcWorldName(string worldPath, string newWorldName) {
            MinecraftNBTmodel model = ReadMcNBTfile(worldPath);
            model.WorldName = newWorldName;
            UpdateMcNBTfile(worldPath, model);


        }

        private static string getNbtFilePath(string worldPath) {
            return Path.Combine(worldPath, NBTfile);

        }

    }
}
