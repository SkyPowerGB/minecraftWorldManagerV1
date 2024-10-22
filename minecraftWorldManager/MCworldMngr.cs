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
            
            string minecraftSavesPath =GetMcSavesFolder();

            if (!Directory.Exists(minecraftSavesPath)) {

                return;
            
            }

           var directories= Directory.GetDirectories(minecraftSavesPath);

            foreach (String dir in directories) { 
            
            lbMcWorlds.Items.Add(Path.GetFileName(dir));
            
            }


        }


        public static string GetMcSavesFolder() {

            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string minecraftSavesPath = Path.Combine(appDataPath, ".minecraft", "saves");

            return minecraftSavesPath;


        }

    }
}
