using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_StudInfo
{
    public partial class DialogNameList : Form
    {
        Form1 TempForm;
        public DialogNameList(Form1 _FormParent)
        {
            InitializeComponent();
            _FormParent.Enabled = false;
            TempForm = _FormParent;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(!tbNameOfList.Text.Equals(""))
                TempForm.StudentController.Add(new StudentController(tbNameOfList.Text));
            TempForm.Enabled = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TempForm.Enabled = true;
            this.Close();
        }
    }
}
