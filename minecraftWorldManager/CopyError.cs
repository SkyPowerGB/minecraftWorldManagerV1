using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftWorldManager
{
    public partial class FolderExistsErrorForm : Form
    {
        public static int RENAME = 1;
        public static int OVERWRITE = 2;
        public static int CANCEL = 3;
      
        public int result;
        public string NewName { get; set; }
     
    
        public FolderExistsErrorForm(string filePath,string targetFilePath)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.result = CANCEL;
           
            WorldDataFile worldDataFile = WorldDataFileWorker.GetWroldDF(filePath);
            WorldDataFile targetWorldDataFile = WorldDataFileWorker.GetWroldDF(targetFilePath);
            if (worldDataFile != null&&targetWorldDataFile!=null) {


                rtbWorld1DatF.Text +="Last modified:"+ worldDataFile.marked+Environment.NewLine;
                rtbWorld1DatF.Text +=  Environment.NewLine;

                rtbWorld1DatF.Text += "World Version:" + worldDataFile.worldVersion + Environment.NewLine;
                rtbWorld1DatF.Text += Environment.NewLine;

                rtbWorld1DatF.Text += "Minecraft Version:" + worldDataFile.minecraftVersion + Environment.NewLine;
                rtbWorld1DatF.Text += Environment.NewLine;


                rtbWorld2DatF.Text += "Last modified:" + targetWorldDataFile.marked + Environment.NewLine;
                rtbWorld2DatF.Text += Environment.NewLine;

                rtbWorld2DatF.Text += "World Version:" + targetWorldDataFile.worldVersion + Environment.NewLine;
                rtbWorld2DatF.Text += Environment.NewLine;

                rtbWorld2DatF.Text += "Minecraft Version:" + targetWorldDataFile.minecraftVersion + Environment.NewLine;
                rtbWorld2DatF.Text += Environment.NewLine;




            }
        }

        private void CopyError_Load(object sender, EventArgs e)
        {

        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            result = RENAME;
            if (tbNewWorldName.Text == ""||tbNewWorldName.Text==" ") { return; }
            NewName = tbNewWorldName.Text;
           
            this.Close();
        }

        private void btnOverWrite_Click(object sender, EventArgs e)
        {
            result=OVERWRITE;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = CANCEL;
            this.Close();
        }

     




    }


}
