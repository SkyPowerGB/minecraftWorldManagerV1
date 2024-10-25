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
    public partial class WFeditor : Form
    {
        public WorldDataFile worldDataFile;
        public DialogResult result { get; private set; }

        public WFeditor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.worldDataFile = new WorldDataFile(); 
            loadData();
        }

        public WFeditor(WorldDataFile worldDataFile)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.worldDataFile = worldDataFile ?? new WorldDataFile(); 
            loadData();
        }

        public WFeditor(string worldPath)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (WorldDataFileWorker.IsMarked(worldPath))
            {
                this.worldDataFile = WorldDataFileWorker.GetWroldDF(worldPath);
            }
            else
            {
                this.worldDataFile = new WorldDataFile(); 
            }

            loadData();
        }

        private void loadData()
        {
            if (worldDataFile == null) return;

            tbWorldVersion.Text = worldDataFile.worldVersion ?? string.Empty; 
            cbMcVersion.Text = worldDataFile.minecraftVersion ?? string.Empty; 
            tbDescription.Text=worldDataFile.Description ?? string.Empty;
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            
            worldDataFile.worldVersion = tbWorldVersion.Text; 
            worldDataFile.minecraftVersion = cbMcVersion.Text; 
            worldDataFile.Description=tbDescription.Text;
            result = DialogResult.OK;
            this.Close();
        }

        public WorldDataFile GetWorldDataFile()
        {
            return worldDataFile;
        }

        private void WFeditor_Load(object sender, EventArgs e)
        {

        }
    }
}
