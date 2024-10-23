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

        private void refreshLists() {
            LoadSaves();
            LoadBackups();  
            LoadQsaves();
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

        private void LoadSaves(bool def) {
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

        private void LoadQsaves() {
            lbQuickBackups.Items.Clear ();
          var path=  tbQbackupsLocPath.Text;
            if(path == null) { return; }
            var dirs=Directory.GetDirectories(path);
            foreach (string dir in dirs) { 
               
                lbQuickBackups.Text = Path.GetFileName(dir);
            
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
            this.StartPosition = FormStartPosition.CenterScreen;
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
                McFileMngr.CreateBranch(item.ToString(),tbBackupsPath.Text);
                refreshLists();
            }
            
        }

        private void showErrorMsg(String error) {
            MessageBox.Show(error);
        }

        private void lbBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBranch.Clear();
            var backup = lbBackups.SelectedItem;
            if (backup== null) {
                return;
            
            
            
            }
            var backupPath=Path.Combine(tbBackupsPath.Text,backup.ToString());
            if (!WorldDataFileWorker.IsBranch(backupPath)) { return; }

            var dirs=Directory.GetDirectories(backupPath);
            lbBranchContents.Items.Clear();
            tbBranch.Text = backupPath;

            foreach (string dir in dirs) { 
               
                lbBranchContents.Items.Add(Path.GetFileName(dir));
            
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

            McFileMngr.CopyWorldTo(worldPath, targetPath);
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
            if (item == null && path == null ) {

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
            InputForm input =new InputForm();
            var selectedWorld = lbMcWorlds.SelectedItem;
            if (selectedWorld == null) {
                showErrorMsg("no world selected");
                return;
            }

            input.ShowDialog();
          var result=  input.GetResult();
            if (DialogResult.OK != result) {
                return;
            }

  
            string savesFolderPath = tbMcSavesLocPath.Text;
            string worldPath = Path.Combine(savesFolderPath, selectedWorld.ToString());
            string newName = input.GetInput();

            McFileMngr.RenameWorld(savesFolderPath,worldPath,newName);
            refreshLists();

            
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
    }
}
