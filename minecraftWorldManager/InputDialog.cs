using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraftWorldManager
{
    public partial class InputForm : Form
    {

        private string inputName;
        public bool RenameWorld {  get; set; }
        private DialogResult result;

        public InputForm()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        public InputForm(bool hideChckBox) {
            InitializeComponent();
            if (hideChckBox) { 
            chckBworldToo.Visible = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)

        {
            result=DialogResult.Cancel;
            this.Close();
        }



        public string GetNewName() {
            return inputName; }

        private void button1_Click(object sender, EventArgs e)
        { 
            RenameWorld=chckBworldToo.Checked;
            inputName =tbNewName.Text;
            result = DialogResult.OK;
            this.Close();

        }

        public DialogResult GetResult() {   return result; }

        public void SetInput(string input) {
            tbNewName.Text = input;
        }
        private void InputForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
