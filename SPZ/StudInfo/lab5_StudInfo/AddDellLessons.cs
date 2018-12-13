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
    public enum Change { Add,Del,Chg};
    public partial class AddDellLessons : Form
    {
        Form1 MainForm;
        Form2 ParentForm;
        object Mainlist;
        object Datagrid;
        Change change;
        public AddDellLessons(Form1 _form,Form2 _ParentForm,object _MainListSender, object _Datagrid, Change _change)
        {
            InitializeComponent();
            change = _change;
            MainForm = _form;
            Mainlist = _MainListSender;
            Datagrid = _Datagrid;
            ParentForm = _ParentForm;
            if (_change == Change.Add)
                this.Text = "Add Lesson";
            if (_change == Change.Chg)
                this.Text = "Change Lesson";
            if (_change == Change.Del)
                this.Text = "Delete Lesson";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "") {
                if (change == Change.Add)
                    MainForm.StudentController[(Mainlist as ListBox).SelectedIndex].StudentList[(Datagrid as DataGridView).CurrentCellAddress.Y].AddLesson(textBox1.Text, int.Parse(textBox2.Text));
                if (change == Change.Chg)
                {
                    MainForm.StudentController[(Mainlist as ListBox).SelectedIndex].StudentList[(Datagrid as DataGridView).CurrentCellAddress.Y].Change((Datagrid as DataGridView).CurrentCell.Value.ToString(),textBox1.Text,int.Parse(textBox2.Text));
                }
                if(change == Change.Del)
                {
                    MainForm.StudentController[(Mainlist as ListBox).SelectedIndex].StudentList[(Datagrid as DataGridView).CurrentCellAddress.Y].Marks.RemoveAt((Datagrid as DataGridView).CurrentCellAddress.Y);
                }
            }
            ParentForm.binding2.ResetBindings(true);
            this.Close();
        }
    }
}
