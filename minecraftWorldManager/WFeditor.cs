using System;
using System.Windows.Forms;

namespace minecraftWorldManager
{
    public partial class WFeditor : Form
    {
        public WorldDataFile worldDataFile;
        private String WorldPath {get;set;}
        public DialogResult result { get; private set; }

        public WFeditor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.worldDataFile = new WorldDataFile(); 
            loadData();
        }

        public WFeditor(WorldDataFile worldDataFile,string worldPath)
        {
            this.WorldPath = worldPath;
            InitializeComponent();
            loadMcVersion(worldPath);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.worldDataFile = worldDataFile ?? new WorldDataFile(); 
            loadData();
        }

        public WFeditor(string worldPath)
        {
            InitializeComponent();
            loadMcVersion(worldPath);
            this.StartPosition = FormStartPosition.CenterScreen;
           MinecraftNBTmodel data;
            if (WorldDataFileWorker.IsMarked(worldPath))
            {
                data = null;
                this.worldDataFile = WorldDataFileWorker.GetWroldDF(worldPath);
            }
            else
            {
                data = MinecraftNBTfileManager.ReadMcNBTfile(worldPath);
                this.worldDataFile = new WorldDataFile(); 
            }

            
            if (data != null) {
                cbMcVersion.Text = data.WorldVersion;
            }

            loadData();
        }


        public void loadMcVersion(string worldPath) {
            MinecraftNBTmodel data;
            string worldVersion="";

            if (WorldDataFileWorker.IsMarked(worldPath))
            {
                data = null;
                worldVersion = WorldDataFileWorker.GetWroldDF(worldPath).worldVersion;
                cbMcVersion.Text = worldVersion;
            }
            else
            {
                data = MinecraftNBTfileManager.ReadMcNBTfile(worldPath);
                
                worldVersion = data.WorldVersion;
                cbMcVersion.Items.Add(worldVersion);
                cbMcVersion.Text = worldVersion;

            }

             
           

           
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

        private void cbMcVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
