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
    public partial class Form3 : Form
    {
        Form1 MainForm;
        Form2 parentForm;
        object MainLSender;
        bool AddDel; // false - Add ; true - Dellete
        public Form3(Form2 _pform,Form1 _mainForm, object _pSender, object _MainListSender)
        {
            InitializeComponent();
            MainForm = _mainForm;
            parentForm = _pform;
            MainLSender = _MainListSender;
            if ((_pSender as ToolStripMenuItem).AccessibleName == "Add")
                AddDel = false;
            if ((_pSender as ToolStripMenuItem).AccessibleName == "Del")
                AddDel = true;

            if (!AddDel) this.Text = "Добавить студента";
            if (AddDel) this.Text = "Удалить студента";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!AddDel)//adding
            {
                if (!textBox1.Text.Equals(""))
                {
                    MainForm.StudentController[(MainLSender as ListBox).SelectedIndex].AddStudent(textBox1.Text);
                    parentForm.binding1.ResetBindings(true);
                    this.Close();
                }

            }
            if (AddDel)//deleting
            {
                if (!textBox1.Text.Equals(""))
                {
                    MainForm.StudentController[(MainLSender as ListBox).SelectedIndex].DelStudent(textBox1.Text);
                    parentForm.binding1.ResetBindings(true);
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
