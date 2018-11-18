using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CompManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Program.internetBar.Computers.Add(new Computer(textBox1.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Empty name");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
