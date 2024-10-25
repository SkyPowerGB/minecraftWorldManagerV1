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
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MCworldMngr_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }


       
        private void displayWorldData(WorldDataFile df)
        {
            rTbDisplayWFdata.Clear();
            if (df == null) { rTbDisplayWFdata.Text += "NOT STAMPED OR NOT SELECTED"; return; }

            rTbDisplayWFdata.Text += "Stamped:  " + df.marked + Environment.NewLine;
            rTbDisplayWFdata.Text += Environment.NewLine;
            rTbDisplayWFdata.Text += "Last Edited:  " + df.saveDate + Environment.NewLine;
            rTbDisplayWFdata.Text += Environment.NewLine;
            rTbDisplayWFdata.Text += "World Version:  " + df.worldVersion + Environment.NewLine;
            rTbDisplayWFdata.Text += Environment.NewLine;
            rTbDisplayWFdata.Text += "Minecraft version:  " + df.minecraftVersion + Environment.NewLine;
            rTbDisplayWFdata.Text += Environment.NewLine;
            rTbDisplayWFdata.Text += "Description:  " + df.Description + Environment.NewLine;

        }

        private void displayQbckpWorldsNames(string selectedQB)
        {
            rTbDisplayWFdata.Clear();
            var dirs = Directory.GetDirectories(selectedQB);
            foreach (var dir in dirs)
            {
                rTbDisplayWFdata.Text += Path.GetFileName(dir) + Environment.NewLine;
                rTbDisplayWFdata.Text += Environment.NewLine;
            }
        }

        //rename

        private void RenameWorld(string worldPath) {
            InputForm input;
            if (WorldDataFileWorker.IsBranch(worldPath))
            {
                input = new InputForm(true);
            }
            else
            {
                input = new InputForm();
            }
            input.SetInput(Path.GetFileName(worldPath));
            
            input.ShowDialog();
            var result = input.GetResult();
            if (DialogResult.OK != result)
            {
                return;
            }

            if (input.RenameWorld) {

                MinecraftNBTfileManager.UpdateMcWorldName(worldPath,input.GetNewName());
            }
           
            
            string newName = input.GetNewName();


            McFileMngr.RenameWorld(Directory.GetParent(worldPath).FullName, worldPath, newName);

            refreshLists();


        }

        // IS WORLD SELECTED FOR PATH
        public bool isBackupSelected()
        {
            if (lbBackups.SelectedItem == null) { return false; }
            return true;
        }
        public bool isQBackupSelected()
        {
            if (lbQuickBackups.SelectedItem == null) { return false; }
            return true;
        }
        public bool isSaveSelected()
        {

            if (lbMcWorlds.SelectedItem == null)
            {
                return false;
            }
            return true;
        }

        public bool isBranchSelected()
        {
            if (lbBranchContents.SelectedItem == null) { return false; }
            return true;
        }
      
  // GET PATHS      
        public string getSelectedBackupPath()
        {
            if (lbBackups.SelectedItem == null) { return null; }
            return Path.Combine(tbBackupsPath.Text, lbBackups.SelectedItem.ToString());
        }
        public string getSelectedQBackupPath()
        {
            if (lbQuickBackups.SelectedItem == null) { return null; }
            return Path.Combine(tbQbackupsLocPath.Text, lbQuickBackups.SelectedItem.ToString());
        }
        public string getSelectedSavePath()
        {
            if (lbMcWorlds.SelectedItem == null) { return null; }
            return Path.Combine(tbMcSavesLocPath.Text, lbMcWorlds.SelectedItem.ToString());
        }

        public string getSelectedBranchSavePath()
        {
            if (lbBranchContents.SelectedItem == null) { return null; }
            return Path.Combine(tbBranch.Text, lbBranchContents.SelectedItem.ToString());
        }

        public static string GetMcSavesFolder()
        {

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string minecraftSavesPath = Path.Combine(appDataPath, ".minecraft", "saves");

            return minecraftSavesPath;


        }
/*----------------------------------------------------------------------------------------------------
 * 
 * REFRESH ALL LISTS
 
 */

        private void refreshLists()
        {
            LoadSaves();
            LoadBackups();
            LoadQsaves();

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

        private void LoadSaves(bool def)
        {
            if (def) { LoadSaves(); }

            string minecraftSavesPath = tbMcSavesLocPath.Text;

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

            foreach (String dir in backupsDirs)
            {
                if (WorldDataFileWorker.IsMarked(dir) || WorldDataFileWorker.IsBranch(dir))
                {
                    string name = Path.GetFileName(dir);
                    lbBackups.Items.Add(name);

                }

            }

            foreach (String dir in qBackupsDirs)
            {
                string name = Path.GetFileName(dir);
                lbQuickBackups.Items.Add(name);



            }




        }

        private void LoadQsaves()
        {
            lbQuickBackups.Items.Clear();
            var path = tbQbackupsLocPath.Text;
            if (path == null) { return; }
            var dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {

                lbQuickBackups.Items.Add(Path.GetFileName(dir));

            }
        }

       
/*---------------------------------------------------------------------------------------------------------------
 *       POPUP DIALOG
 */

        private void showErrorMsg(String error)
        {
            MessageBox.Show(error);
        }

        private void ConfirmDelete(string worldPath)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this world?", "Confirm DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Directory.Delete(worldPath, true);
                refreshLists();
            }

        }


/*
 
  **********************************************************************************************
  *EVENTS
 */


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

        private void btnSelectBackups_Click(object sender, EventArgs e)
        {
            ProgramDat dataFile = ProgDataFileMngr.GetProgramData();

            ProgramDat data = new ProgramDat();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath=tbBackupsPath.Text;
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

     
        private void btnSelectQbackupFolder_Click(object sender, EventArgs e)
        {
            ProgramDat dataFile = ProgDataFileMngr.GetProgramData();


            ProgramDat data = new ProgramDat();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = dataFile.quickBackupsPath;
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbQbackupsLocPath.Text = folderBrowserDialog.SelectedPath;
                var QbackupsPath= tbQbackupsLocPath.Text; 
                if (tbQbackupsLocPath.Text == tbBackupsPath.Text) {
                    string newDir = "Qbackups";
                    string newPathQBdir = Path.Combine(QbackupsPath,newDir);
                    if (Directory.Exists(newPathQBdir)) { return; }
                   Directory.CreateDirectory(newPathQBdir);
                    QbackupsPath= newPathQBdir;
                
                }

                data.quickBackupsPath = QbackupsPath;
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






        
        }

        private void btnOpenMarkForm_Click(object sender, EventArgs e)
        {
            if (lbMcWorlds.SelectedItem == null)
            {
                showErrorMsg("World not selected!");
                return;
            }

            string selectedWorld = lbMcWorlds.SelectedItem.ToString();
            string worldPath = Path.Combine(tbMcSavesLocPath.Text, selectedWorld);

            WFeditor wFeditor=new WFeditor(worldPath);


            wFeditor.ShowDialog();
            if (wFeditor.result == DialogResult.OK)
            {
                WorldDataFileWorker.MarkWorld(worldPath, wFeditor.GetWorldDataFile());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = lbMcWorlds.SelectedItem;
            
            if (item != null) {
                McFileMngr.CreateBranch(item.ToString(),tbBackupsPath.Text);
                refreshLists();
            }
            
        }

    
        private void lbBackups_SelectedIndexChanged(object sender, EventArgs e)
        {

         

            tbBranch.Clear();
            
            if (!isBackupSelected()) {
                return;
            
          
            }

            var backupPath= getSelectedBackupPath();
            var worldDataFile = WorldDataFileWorker.GetWroldDF(backupPath);

            displayWorldData(worldDataFile);

            if (!WorldDataFileWorker.IsBranch(backupPath)) {  return; }

          

            displayWorldData(worldDataFile);

            var dirs=Directory.GetDirectories(backupPath);

            lbBranchContents.Items.Clear();

            tbBranch.Text = backupPath;

            foreach (string dir in dirs) { 
               
                lbBranchContents.Items.Add(Path.GetFileName(dir));
            
            }

        }

        private void lbMcWorlds_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lbMcWorlds.SelectedItem == null) { return; }
            if (lbMcWorlds.SelectedItem.ToString() == null|| tbMcSavesLocPath.Text==null) { return; }
          
            displayWorldData(WorldDataFileWorker.GetWroldDF(Path.Combine(tbMcSavesLocPath.Text, lbMcWorlds.SelectedItem.ToString())));


        }

        private void btnCutSavesToBackups_Click(object sender, EventArgs e)
        {
            var save = lbMcWorlds.SelectedItem;
            if (save == null) { return; }
            

            string worldPath = Path.Combine(tbMcSavesLocPath.Text,save.ToString());
            if (!WorldDataFileWorker.IsMarked(worldPath)) {
                showErrorMsg("File not marked");
                return; }

            string targetPath = tbBackupsPath.Text;
                
                

            McFileMngr.CutWorldToRnm(worldPath,targetPath,null);

            LoadBackups();
            LoadSaves();

        }

        private void btnCutBckpToSaves_Click(object sender, EventArgs e)
        {
            var save = lbBackups.SelectedItem;
            if (save == null) { return; }


            string worldPath = Path.Combine(tbBackupsPath.Text, save.ToString());

            if (WorldDataFileWorker.IsBranch(worldPath)){ return; }


            string targetPath = tbMcSavesLocPath.Text;
            McFileMngr.CutWorldToRnm(worldPath, targetPath,null);
            LoadSaves();
            LoadBackups();


        }

        private void btnCopyBckpToSaves_Click(object sender, EventArgs e)
        {
            var worldToCopy = lbBackups.SelectedItem;
            if(worldToCopy == null) { return; };
            var savesPath=tbMcSavesLocPath.Text;
            var worldPath=Path.Combine(tbBackupsPath.Text,worldToCopy.ToString());
            McFileMngr.CopyWorldTo(worldPath,savesPath,false);
            refreshLists();
        }

        private void btnCopySavesToBackup_Click(object sender, EventArgs e)
        {
            
            var worldToCopy = lbMcWorlds.SelectedItem;
            if (worldToCopy == null) { return; };
            var backupsPath = tbBackupsPath.Text;
            var worldPath = Path.Combine(tbMcSavesLocPath.Text, worldToCopy.ToString());
            if (!WorldDataFileWorker.IsMarked(worldPath)) { showErrorMsg("World isnt MARKED!"); return; } 
            McFileMngr.CopyWorldTo(worldPath, backupsPath,false);
            refreshLists();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            var world = lbMcWorlds.SelectedItem;
            if (world == null) { return; }

            ConfirmDelete(Path.Combine(tbMcSavesLocPath.Text,world.ToString()));
        }
      
        private void button8_Click(object sender, EventArgs e)
        {
            var world = lbBackups.SelectedItem;
            if (world == null) { return; }

            ConfirmDelete(Path.Combine(tbBackupsPath.Text, world.ToString()));
            tbBranch.Clear();
            lbBranchContents.Items.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var item=lbMcWorlds.SelectedItem;
            var branch=tbBranch.Text;
            if (item == null||branch==null||branch==" ") { return; }

            var targetPath = Path.Combine(branch, item.ToString());
            var worldPath = Path.Combine(tbMcSavesLocPath.Text, item.ToString());
            if (!WorldDataFileWorker.IsMarked(worldPath)) { showErrorMsg("World not marked!"); return; }

            var dataFile = WorldDataFileWorker.GetWroldDF(worldPath);
            var dateTimeOffset = new DateTimeOffset(DateTime.Now);

            var newName =  Path.GetFileName(worldPath)+  " d" +dateTimeOffset.ToUnixTimeSeconds().ToString();



            McFileMngr.CopyWorldToRnm(worldPath, branch,newName,false);
            refreshLists();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var item = lbMcWorlds.SelectedItem;
            var branch = tbBranch.Text;
            if (item == null && branch == null && branch == " ") { return; }

            
            var worldPath = Path.Combine(tbMcSavesLocPath.Text, item.ToString());
            if (!WorldDataFileWorker.IsMarked(worldPath)) { showErrorMsg("World not marked!"); return; }
            var dataFile=WorldDataFileWorker.GetWroldDF(worldPath);
            var dateTimeOffset = new DateTimeOffset(DateTime.Now);

            var newName = Path.GetFileName(worldPath) + " d" + dateTimeOffset.ToUnixTimeSeconds().ToString();

            McFileMngr.CutWorldToRnm(worldPath, branch,newName);
            refreshLists();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var worldName = lbBranchContents.SelectedItem;
            var branchPath = tbBranch.Text;
            if (worldName == null && branchPath == null && branchPath == " ") { return; }

            var targetPath = tbMcSavesLocPath.Text;
            var worldPath = Path.Combine(branchPath, worldName.ToString());

            Console.WriteLine("targer:" +targetPath);
            Console.WriteLine("world:" + worldPath);

            McFileMngr.CopyWorldTo(worldPath, targetPath, false);
            refreshLists();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            var item = lbBranchContents.SelectedItem;
            var branch = tbBranch.Text;
            if (item == null && branch == null && branch == " ") { return; }

            var targetPath = tbMcSavesLocPath.Text;
            var worldPath = Path.Combine(tbBranch.Text, item.ToString());
            Console.WriteLine("targer:" + targetPath);
            Console.WriteLine("world:" + worldPath);

            McFileMngr.CutWorldToRnm(worldPath, targetPath,null);
            refreshLists();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var item=lbBranchContents.SelectedItem;
            var path = tbBranch.Text;
            if (item == null || path == null ) {

                return;
            }
           
             
            ConfirmDelete(Path.Combine(path, item.ToString()));
            lbBranchContents.Items.Clear();
            tbBranch.Clear();
        }

        private void btnSelectSavesFold_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.SelectedPath = tbMcSavesLocPath.Text;
           var result=ofd.ShowDialog();
            if (DialogResult.OK ==result ) { 
               tbMcSavesLocPath.Text = ofd.SelectedPath;
                LoadSaves(false);
                return;
            }
        }

        private void tbMcSavesLocPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var result=dialog.ShowDialog();
            if (DialogResult.OK == result) { 
            tbLocalWorldPath.Text = dialog.SelectedPath;
            
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
                McFileMngr.CutWorldTo(
                    tbLocalWorldPath.Text,
                    Path.Combine(tbMcSavesLocPath.Text,Path.GetFileName(tbLocalWorldPath.Text)));


            
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            var selectedWorld = lbMcWorlds.SelectedItem;

            if (!isSaveSelected()) {
                showErrorMsg("no world selected");
                return;
            }
           
        
  
          
            string worldPath = getSelectedSavePath();

            RenameWorld(worldPath);
          



            
        }

        private void btnQuickBackup_Click(object sender, EventArgs e)
        {
            var targetFolder = tbQbackupsLocPath.Text;
            if (targetFolder == null) { return; }
            string worlds=tbMcSavesLocPath.Text;
            if(worlds == null) { return; }

            DateTimeOffset  offset=DateTimeOffset.Now;

            var newFolderName=Path.GetFileName(worlds)+ " _DS" + offset.ToUnixTimeSeconds();

            var data = QbckpFileMngr.GetQuickBckpData();
            if (data == null) {
                data = new QuickBackupsDat();
              
                QbckpFileMngr.UpdateQbckpData(data);
            }

            
         
            McFileMngr.CopyWorldToRnm(worlds,tbQbackupsLocPath.Text,newFolderName,false);
            refreshLists() ;
        }

        private void btnQuickBackupImport_Click(object sender, EventArgs e)
        {
            var qbackup = lbQuickBackups.SelectedItem;
            var saves = tbMcSavesLocPath.Text;
            if (qbackup==null)
            {
                showErrorMsg("quick backup not selected");
                return;
            }
            var qBackupPath = Path.Combine(tbQbackupsLocPath.Text, qbackup.ToString());


            McFileMngr.CopyAllSubdirsTo(qBackupPath,saves);

            refreshLists();


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var qbPath = tbQbackupsLocPath.Text;
            var qb=lbQuickBackups.SelectedItem;
            if (qb == null) { return; }
            if (qbPath == null) { return; }
            var fileToDelete = Path.Combine(qbPath, qb.ToString());
            ConfirmDelete(fileToDelete);
            refreshLists();
        }
       
        private void button13_Click(object sender, EventArgs e)
        {

           

            if (!isBackupSelected())
            {
                showErrorMsg("no world selected");
                return;
            }
           


            string worldPath = getSelectedBackupPath();
            

            RenameWorld(worldPath);



        }

        private void lbQuickBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isQBackupSelected()) {return; }
            displayQbckpWorldsNames(getSelectedQBackupPath());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!isBranchSelected())
            {
                showErrorMsg("no world selected");
                return;
            }



            string worldPath = getSelectedBranchSavePath();


            RenameWorld(worldPath);


        }

        private void btnEditMark_Click(object sender, EventArgs e)
        {
            var selectedBackup=lbBackups.SelectedItem;
            var backupsPath=tbBackupsPath.Text;
            if (selectedBackup == null || backupsPath == null) { return; }
           var backupWorldPath= Path.Combine(backupsPath, selectedBackup.ToString());
            if (!WorldDataFileWorker.IsMarked(backupWorldPath)) { return; }
           WorldDataFile worldDf= WorldDataFileWorker.GetWroldDF(backupWorldPath);

            WFeditor editor=new WFeditor(worldDf);
            editor.ShowDialog();
            if (editor.result == DialogResult.OK) {

                WorldDataFileWorker.MarkWorld(backupWorldPath,editor.GetWorldDataFile());
            
            }
           

           
        }
        private void lbBranchContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayWorldData(WorldDataFileWorker.GetWroldDF(getSelectedBranchSavePath()));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!isSaveSelected()) { return; }
            EditWorldNBTform form = new EditWorldNBTform(getSelectedSavePath());
            form.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!isBackupSelected()) { return; }
            if (WorldDataFileWorker.IsBranch(getSelectedBackupPath())) { return; }
            EditWorldNBTform form = new EditWorldNBTform(getSelectedBackupPath());
            form.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
        
            if(!isBranchSelected()) { return; }
            EditWorldNBTform form = new EditWorldNBTform(getSelectedBranchSavePath());
            form.ShowDialog();
        }

        private void rTbDisplayWFdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyToSaves_Click(object sender, EventArgs e)
        {
            McFileMngr.CopyWorldToRnm(
                tbLocalWorldPath.Text,
            tbMcSavesLocPath.Text,null,false);
            refreshLists();
        }
    }


}
