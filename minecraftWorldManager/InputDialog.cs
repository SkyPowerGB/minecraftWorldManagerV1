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
        private DialogResult result;

        public InputForm()
        {
            
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)

        {
            result=DialogResult.Cancel;
            this.Close();
        }



        public string GetInput() {
            return inputName; }

        private void button1_Click(object sender, EventArgs e)
        {
            inputName =tbNewName.Text;
            result = DialogResult.OK;
            this.Close();

        }

        public DialogResult GetResult() {   return result; }

        private void InputForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
