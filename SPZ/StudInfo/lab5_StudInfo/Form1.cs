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
    public partial class Form1 : Form
    {
        internal BindingList<StudentController> StudentController;
        BindingSource binding;

        

        public Form1()
        {
            InitializeComponent();
            StudentController = new BindingList<StudentController>();
            lbStudents.DataSource = StudentController;
            binding = new BindingSource();

            //binding.DataSource = StudentController[lbStudents.SelectedIndex].FindName(tbSortByStud.Text).Marks;
            dataGridView1.DataSource = binding;

        }

        private void btStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("May the Force be with you.");
        }

        private void btSerialize_Click(object sender, EventArgs e)
        {
            StudentController[lbStudents.SelectedIndex].ToSerialize(tbFileName.Text);
        }

        private void btDeSerialize_Click(object sender, EventArgs e)
        {
            StudentController[lbStudents.SelectedIndex].DeSerialize(tbFileName.Text);
        }

        private void btAddControlList_Click(object sender, EventArgs e)
        {
            DialogNameList dialogName = new DialogNameList(this);
            dialogName.Show();
            //StudentController.Add(new StudentController())
        }

        private void btDellControlList_Click(object sender, EventArgs e)
        {
            if (StudentController.Count != 0)
                StudentController.Remove(StudentController[lbStudents.SelectedIndex]);
        }

        private void lbStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form2 form = new Form2(this,sender);
            form.Show();
        }

        private void tbSortByStud_TextChanged(object sender, EventArgs e)
        {

            var Lessons = 
                    from student in StudentController[lbStudents.SelectedIndex].StudentList
                    where student.StudentName.Contains(tbSortByStud.Text)
                    select student.StudentName;
            
            
                binding.DataSource = Lessons;
            binding.ResetBindings(true);
        }

        
    }
}
