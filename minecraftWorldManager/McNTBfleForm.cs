using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftWorldManager
{
    public partial class EditWorldNBTform : Form
    {
        private static readonly Dictionary<int, string> GameModesMap = new Dictionary<int, string>
{
    { 0, "Survial" },
    { 1, "Creative" },
    { 2, "Adventure" },
    { 3, "Spectator" },
    { 4,"Hardcore"}
};


        private static readonly Dictionary<int, string> DifficultyMap = new Dictionary<int, string>
{
    { 0, "Peacefull" },
    { 1, "Easy" },
    { 2, "Normal" },
    { 3, "Hard" }
};

        private void loadComboBoxes() {
            var difficultiesList = DifficultyMap.Values.ToList();
            var gameModesList=GameModesMap.Values.ToList();
            cbDifficulty.DataSource = difficultiesList;
            cbGameMode.DataSource = gameModesList;  
        
        }

        private string WorldPath {  get; set; }
        public MinecraftNBTmodel minecraftNBTmodel { get; set; }
        public DialogResult dialogResult { get; set; }
  
        public EditWorldNBTform(string worldPath) {

            this.WorldPath = worldPath;
                 InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            loadComboBoxes();
            minecraftNBTmodel =MinecraftNBTfileManager.ReadMcNBTfile(worldPath);
            if(minecraftNBTmodel == null ) { return; }
            if (minecraftNBTmodel.WorldName != null)
            {
                tbWorldName.Text = minecraftNBTmodel.WorldName;
            }
      
            dialogResult = DialogResult.Cancel;
          
            if (minecraftNBTmodel.Hardcore) {
                Console.WriteLine("hardcore");
                cbGameMode.SelectedItem = GameModesMap[4]; } else {
                cbGameMode.SelectedItem = GameModesMap[minecraftNBTmodel.GameMode];
            }
            
            cbDifficulty.SelectedItem = DifficultyMap[minecraftNBTmodel.GameDifficulty];
            chckBxCmdAllowed.Checked = minecraftNBTmodel.AllowCommands;
            chckBxDifficultyLock.Checked = minecraftNBTmodel.DifficultyLocked;
            
            
           
            
        }
        private void EditWorldNBTform_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dialogResult = DialogResult.OK;
            var newWorldname=tbWorldName.Text;
            if(newWorldname == null ) { showErrorMessage("world name cannot be empty");  return; }   

            var difficulty = getDataOutOfDictionary(cbDifficulty.Text,DifficultyMap);
            var gameMode = getDataOutOfDictionary(cbGameMode.Text, GameModesMap);
            if (difficulty == -1 && gameMode == -1) { showErrorMessage("error difficutly or gamemode returned -1"); return; }
            var commandsAllowed = chckBxCmdAllowed.Checked;
            var difficultyLocked = chckBxDifficultyLock.Checked;

            minecraftNBTmodel.DifficultyLocked = difficultyLocked;
            minecraftNBTmodel.GameDifficulty =(byte) difficulty;
            minecraftNBTmodel.AllowCommands = chckBxCmdAllowed.Checked;
            minecraftNBTmodel.WorldName=newWorldname;

            if (gameMode == 4)
            {
                minecraftNBTmodel.Hardcore = true;
                minecraftNBTmodel.GameMode =(byte) getDataOutOfDictionary("Survial", DifficultyMap);
            }
            else
            {
                minecraftNBTmodel.Hardcore = false;
                minecraftNBTmodel.GameMode = (byte)gameMode;
            }
            
            MinecraftNBTfileManager.UpdateMcNBTfile(this.WorldPath, minecraftNBTmodel);

            this.Close();
        }
        public void showErrorMessage(string msg) { 
            MessageBox.Show(msg);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dialogResult= DialogResult.Cancel;

            this.Close();
        }

        private int getDataOutOfDictionary(string value,Dictionary<int,string> dictionary ) {

            foreach (var kvp in dictionary) {
                if (kvp.Value == value) {
                    return kvp.Key;
                }
            }

            return -1;
        }
      
     
        
    
    }
}
