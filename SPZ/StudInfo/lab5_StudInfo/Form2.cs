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
    public partial class Form2 : Form
    {
        object MainListSender;
        Form1 TempForm;
        internal BindingSource binding1;
        internal BindingSource binding2;
        public Form2(Form1 form,object sender)
        {
            InitializeComponent();
            TempForm = form;

            MainListSender = sender;
            binding1 = new BindingSource();
            binding2 = new BindingSource();
            foreach (var element in form.StudentController)
                if ((MainListSender as ListBox).SelectedItem == element)
                {
                    binding1.DataSource = element.StudentList;
                    
                    
                }
            dataGridView1.DataSource = binding1;
            binding1.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddStudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this, TempForm, sender,MainListSender);
            form.Show();
        }

        private void DelStudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(this, TempForm, sender,MainListSender);
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var element in TempForm.StudentController)
                if ((MainListSender as ListBox).SelectedItem == element)
                {
                    if (dataGridView1.CurrentCellAddress.Y > -1)
                        
                    binding1.ResetBindings(true);
                }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var element in TempForm.StudentController)
                if ((MainListSender as ListBox).SelectedItem as StudentController == element)
                {
                    if (dataGridView1.CurrentCellAddress.Y > -1)
                    {
                        binding2.DataSource = element.StudentList[dataGridView1.CurrentCellAddress.Y].Marks;
                        dataGridView2.DataSource = binding2;
                        binding2.ResetBindings(true);
                    }
                }
        }

        private void addLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDellLessons addDellLessons = new AddDellLessons(TempForm, this, MainListSender, dataGridView1, Change.Add);
            addDellLessons.Show();
        }

        private void changeLsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDellLessons addDellLessons = new AddDellLessons(TempForm, this, MainListSender, dataGridView1, Change.Chg);
            addDellLessons.Show();
        }

        private void delLsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDellLessons addDellLessons = new AddDellLessons(TempForm, this, MainListSender, dataGridView1, Change.Del);
            addDellLessons.Show();
        }
    }
}
