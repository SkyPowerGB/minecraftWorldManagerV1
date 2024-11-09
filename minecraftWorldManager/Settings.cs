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
    public partial class Settings : Form
    {
        public QuickBackupsDat model;
        public DialogResult result = DialogResult.Cancel;
        public Settings(QuickBackupsDat model)
        {
            this.model = model; 
            
            InitializeComponent();

            tbD.Text = model.numDays.ToString();
            tbH.Text = model.numHours.ToString();
            tbM.Text = model.numMinute.ToString();
        }

        public int getNumber(string num) {
            int a;
            if (!int.TryParse(num,out a)) { return 0; }

            return int.Parse(num) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.numDays = getNumber(tbD.Text);    
            model.numHours = getNumber(tbH.Text);
            model.numMinute = getNumber(tbM.Text);

            model.lastBackup = DateTime.Now;    
            QbckpFileMngr.UpdateQbckpData(model);
            result = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var num=getNumber(tbD.Text);
            num++;
            tbD.Text = num.ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbH.Text);
            num++;
            tbH.Text = num.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbM.Text);
            num++;
            tbM.Text = num.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbD.Text);
            num--;
            tbD.Text = num.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbH.Text);
            num--;
            tbH.Text = num.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbM.Text);
            num--;
            tbM.Text = num.ToString();
        }
    }
}
