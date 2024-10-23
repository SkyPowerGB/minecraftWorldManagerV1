using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftWorldManager
{
    public partial class MCworldMngr : Form
    {

        
        public MCworldMngr()
        {
            InitializeComponent();
            LoadSaves();
            LoadBackups();
        }

        private void refreshLists() {
            LoadSaves();
            LoadBackups();  
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadSaves_Click(object sender, EventArgs e)
        {
            LoadSaves();


        }


        public static string GetMcSavesFolder()
        {

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string minecraftSavesPath = Path.Combine(appDataPath, ".minecraft", "saves");

            return minecraftSavesPath;


        }

        private void LoadSaves()
        {

            string minecraftSavesPath = GetMcSavesFolder();

            if (!Directory.Exists(minecraftSavesPath))
            {

                return;

            }
            tbMcSavesLocPath.Text = minecraftSavesPath;

            var directories = Directory.GetDirectories(minecraftSavesPath);
            lbMcWorlds.Items.Clear();

            foreach (String dir in directories)
            {

                lbMcWorlds.Items.Add(Path.GetFileName(dir));

            }



        }

        private void LoadBackups()
        {
            ProgramDat dataFile = ProgDataFileMngr.GetProgramData();
            if (dataFile == null) { return; }
            tbBackupsPath.Text = dataFile.backupsPath;
            tbQbackupsLocPath.Text = dataFile.quickBackupsPath;
            lbQuickBackups.Items.Clear();
            lbBackups.Items.Clear();

            var backupsDirs = Directory.GetDirectories(tbBackupsPath.Text);

            var qBackupsDirs = Directory.GetDirectories(tbQbackupsLocPath.Text);

            foreach (String dir in backupsDirs) {
                if (WorldDataFileWorker.IsMarked(dir)||WorldDataFileWorker.IsBranch(dir)){
               string name= Path.GetFileName(dir);
                    lbBackups.Items.Add(name);
                
                }
            
            }

            foreach (String dir in qBackupsDirs)
            {
                 string name = Path.GetFileName(dir);
                    lbQuickBackups.Items.Add(name);

                

            }




        }

        private void btnSelectBackups_Click(object sender, EventArgs e)
        {
            ProgramDat dataFile = ProgDataFileMngr.GetProgramData();

            ProgramDat data = new ProgramDat();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbBackupsPath.Text = folderBrowserDialog.SelectedPath;

                data.backupsPath = tbBackupsPath.Text;
                if (dataFile != null)
                {
                    data.quickBackupsPath = dataFile.quickBackupsPath;

                }
                ProgDataFileMngr.UpdateProgData(data);
                LoadBackups();

                return;
            }
            return;






        }



        private void MCworldMngr_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectQbackupFolder_Click(object sender, EventArgs e)
        {
            ProgramDat dataFile = ProgDataFileMngr.GetProgramData();


            ProgramDat data = new ProgramDat();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbQbackupsLocPath.Text = folderBrowserDialog.SelectedPath;

                data.quickBackupsPath = tbQbackupsLocPath.Text;
                if (dataFile == null)
                {
                    ProgDataFileMngr.UpdateProgData(data);
                    return;
                }
                data.backupsPath = dataFile.backupsPath;

                ProgDataFileMngr.UpdateProgData(data);

                LoadBackups();
            }


            return;






            return;
        }

        private void btnOpenMarkForm_Click(object sender, EventArgs e)
        {
            if (lbMcWorlds.SelectedItem == null) {
                showErrorMsg("World not selected!");
                return;
            }
           string selectedWorld=lbMcWorlds.SelectedItem.ToString();
            string worldPath = Path.Combine(tbMcSavesLocPath.Text, selectedWorld);



            WFeditor wFeditor;


            if (WorldDataFileWorker.IsMarked(worldPath)) {
                wFeditor = new WFeditor(WorldDataFileWorker.GetWroldDF(worldPath));
            }
            else
            {
                wFeditor = new WFeditor(worldPath);
            }

            var file= WorldDataFileWorker.GetWroldDF(worldPath);


            
            wFeditor.ShowDialog();
            if (wFeditor.WorldDataFile != null)
            {
              
                    WorldDataFileWorker.MarkWorld(worldPath, wFeditor.WorldDataFile);
                
              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = lbMcWorlds.SelectedItem;

            if (item != null) { 
            }
        }

        private void showErrorMsg(String error) {
            MessageBox.Show(error);
        }

        private void lbBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMcWorlds.SelectedIndex != -1)
            {
                lbMcWorlds.ClearSelected();
            }




        }


        private void ShowWorldData(string worldPath) {
            rTbDisplayWFdata.Clear();

            bool isbranch = WorldDataFileWorker.IsBranch(worldPath);
            if (!WorldDataFileWorker.IsMarked(worldPath)&&!isbranch )
            {

                rTbDisplayWFdata.Text += "NOT MARKED";
                return;
            }

            if (isbranch)
            {
            }
            else
            {
                var file = WorldDataFileWorker.GetWroldDF(worldPath);
                rTbDisplayWFdata.Text += "Date marked version:" + file.marked;
                rTbDisplayWFdata.Text += Environment.NewLine;
                rTbDisplayWFdata.Text += "Minecraft version:" + file.minecraftVersion;
                rTbDisplayWFdata.Text += Environment.NewLine;

                rTbDisplayWFdata.Text += "World version:" + file.worldVersion;
            }



        }

        private void lbMcWorlds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBackups.SelectedIndex != -1)
            {
                lbBackups.ClearSelected();
            }
            if (lbMcWorlds.SelectedItem == null) { return; }
            if (lbMcWorlds.SelectedItem.ToString() == null|| tbMcSavesLocPath.Text==null) { return; }
            ShowWorldData(Path.Combine(tbMcSavesLocPath.Text,lbMcWorlds.SelectedItem.ToString()));
        }

        private void btnCutSavesToBackups_Click(object sender, EventArgs e)
        {
            var save = lbMcWorlds.SelectedItem;
            if (save == null) { return; }
            

            string worldPath = Path.Combine(tbMcSavesLocPath.Text,save.ToString());
            if (!WorldDataFileWorker.IsMarked(worldPath)) {
                showErrorMsg("File not marked");
                return; }

            string targetPath = Path.Combine(tbBackupsPath.Text, save.ToString());
                
                

            McFileMngr.CutWorldTo(worldPath,targetPath);

            LoadBackups();
            LoadSaves();

        }

        private void btnCutBckpToSaves_Click(object sender, EventArgs e)
        {
            var save = lbBackups.SelectedItem;
            if (save == null) { return; }


            string worldPath = Path.Combine(tbBackupsPath.Text, save.ToString());
          
          

            string targetPath = Path.Combine(tbMcSavesLocPath.Text, save.ToString());
            McFileMngr.CutWorldTo(worldPath, targetPath);
            LoadSaves();
            LoadBackups();


        }

        private void btnCopyBckpToSaves_Click(object sender, EventArgs e)
        {
            var worldToCopy = lbBackups.SelectedItem;
            if(worldToCopy == null) { return; };
            var savesPath=tbMcSavesLocPath.Text;
            var worldPath=Path.Combine(tbBackupsPath.Text,worldToCopy.ToString());
            McFileMngr.CopyWorldTo(worldPath,savesPath);
            refreshLists();
        }

        private void btnCopySavesToBackup_Click(object sender, EventArgs e)
        {
            
            var worldToCopy = lbMcWorlds.SelectedItem;
            if (worldToCopy == null) { return; };
            var backupsPath = tbBackupsPath.Text;
            var worldPath = Path.Combine(tbMcSavesLocPath.Text, worldToCopy.ToString());
            if (!WorldDataFileWorker.IsMarked(worldPath)) { showErrorMsg("World isnt MARKED!"); return; } 
            McFileMngr.CopyWorldTo(worldPath, backupsPath);
            refreshLists();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var world = lbMcWorlds.SelectedItem;
            if (world == null) { return; }

            ConfirmDelete(Path.Combine(tbMcSavesLocPath.Text,world.ToString()));
        }
        private void ConfirmDelete(string worldPath) {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this world?", "Confirm DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Directory.Delete(worldPath,true);
                refreshLists();
            }
             
        }

    }
}
