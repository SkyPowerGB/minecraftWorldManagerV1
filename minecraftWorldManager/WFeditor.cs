﻿using System;
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
        public WorldDataFile WorldDataFile { get; set; }
        public WFeditor()
        {
            InitializeComponent();
            loadData();

        }
        public WFeditor(WorldDataFile WorldDataFile)
        {
            InitializeComponent();
            tbWorldVersion.Text = WorldDataFile.worldVersion;
            cbMcVersion.Text = WorldDataFile.minecraftVersion;
            loadData();
        }


        public WFeditor(String worldPath)
        {
        

            InitializeComponent();
            this.WorldDataFile = WorldDataFileWorker.GetWroldDF(worldPath);
            loadData();
        }


        private void WFeditor_Load(object sender, EventArgs e)
        {

        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            WorldDataFile = new WorldDataFile(tbWorldVersion.Text,cbMcVersion.Text);
            this.Close();
        }


        private void loadData() {
            if (WorldDataFile == null) { return; }

            tbWorldVersion.Text = WorldDataFile.worldVersion;
            cbMcVersion.Text= WorldDataFile.minecraftVersion;
        
        }
    }
}