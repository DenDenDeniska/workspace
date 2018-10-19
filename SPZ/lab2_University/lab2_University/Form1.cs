using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace lab2_University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            listBox1.DataSource = Program.controller.Universities;

            Number_of_faculties.Text = "";
            Number_of_LecRooms.Text = "";
            Number_of_Labs.Text = "";
           
        }

       

      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (University_Name.Text.Equals(""))
            {
                label4.Text = "Пустое поле ввода имени университета !";
                return;
            }
            for (int i = 0; i < University_Name.Text.Length; i++)
            {
                if (University_Name.Text[i] >= '0' && University_Name.Text[i] <= '9')
                {

                    label4.Text = "Недопустимое имя университета";
                    return;
                }
            }
            if(Program.controller.AddUniversity(University_Name.Text))
            {
                label4.Text = "Университет " + University_Name.Text + " добавлен в базу .";
            }
            else
            {
                label4.Text = "Университет " + University_Name.Text + " уже есть в базе .";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            Program.controller.RemoveUniversity(listBox1.SelectedItem.ToString());
            label4.Text = "Университет " + University_Name.Text + " удален .";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            if (UName1.Text.Equals("") || UName2.Text.Equals(""))
            {
                label4.Text = "Пустое поле ввода имени университета !";
                return;
            }
            for (int i = 0; i < UName1.Text.Length; i++)
            {
                if (UName1.Text[i] >= '0' && UName1.Text[i] <= '9')
                {

                    label4.Text = "Недопустимое имя университета";
                    return;
                }
            }
            for (int i = 0; i < UName2.Text.Length; i++)
            {
                if (UName2.Text[i] >= '0' && UName2.Text[i] <= '9')
                {

                    label4.Text = "Недопустимое имя университета";
                    return;
                }
            }
            University temp1 = Program.controller.FindByName(UName1.Text);
            University temp2 = Program.controller.FindByName(UName2.Text);
            if(temp1 != null && temp2 != null)
            {
                Program.controller.AddUniversity(temp1 + temp2);
                label4.Text = "Слияние университетов " + UName1 + " и " + UName2.Text + " добавлено в базу .";
            }
            else if(temp1 == null)
            {
                label4.Text = UName1 + " не найден в базе .";
            }
            else if(temp2 == null)
            {
                label4.Text = UName2 + " не найден в базе .";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.controller.Universities.Count != 0)
            {
                listBox2.DataSource = Program.controller.FindByName(listBox1.SelectedItem.ToString()).Faculties;
                listBox3.DataSource = Program.controller.FindByName(listBox1.SelectedItem.ToString()).LectionRooms;
                listBox4.DataSource = Program.controller.FindByName(listBox1.SelectedItem.ToString()).Labs;

                Number_of_faculties.Text = Program.controller.FindByName(listBox1.SelectedItem.ToString()).NumberOfFaculties.ToString();
                Number_of_Labs.Text = Program.controller.FindByName(listBox1.SelectedItem.ToString()).NumberOfLabs.ToString();
                Number_of_LecRooms.Text = Program.controller.FindByName(listBox1.SelectedItem.ToString()).NumberOfLectionRooms.ToString();

                Number_of_Students.Text = "Студенты : " + Program.controller.FindByName(listBox1.SelectedItem.ToString()).NumberOfStudents.ToString();
                Number_of_Teachers.Text = "Преподаватели : " + Program.controller.FindByName(listBox1.SelectedItem.ToString()).NumberOfTeachers.ToString();
                Number_of_Staff.Text =  "Персонал : " + Program.controller.FindByName(listBox1.SelectedItem.ToString()).NumberOfStaff.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(Program.controller.Universities.Count != 0)
            {
                foreach (var element in Program.controller.FindByName(listBox1.SelectedItem.ToString()).LectionRooms)
                {
                    if (element.Equals(Room_Name.Text))
                    {
                        label4.Text = "Аудитория " + Room_Name.Text + " уже сеществует";
                        return;
                    }
                }

                Program.controller.FindByName(listBox1.SelectedItem.ToString()).AddingLectionRooms(Room_Name.Text);
            }
            else
            {
                label4.Text = "База университетов не заполнена !";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.controller.Universities.Count != 0)
            {
                foreach (var element in Program.controller.FindByName(listBox1.SelectedItem.ToString()).Labs)
                {
                    if (element.Equals(Lab_Name.Text))
                    {
                        label4.Text = "Лаборатория " + Lab_Name.Text + " уже сеществует";
                        return;
                    }
                }

                Program.controller.FindByName(listBox1.SelectedItem.ToString()).AddingLabs(Lab_Name.Text);
            }
            else
            {
                label4.Text = "База университетов не заполнена !";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.controller.FindByName(listBox1.SelectedItem.ToString()).EnrollmentStud();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.controller.FindByName(listBox1.SelectedItem.ToString()).RemandStud();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.controller.FindByName(listBox1.SelectedItem.ToString()).EnrollmentStaff(1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.controller.FindByName(listBox1.SelectedItem.ToString()).RemandStaff(1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.controller.FindByName(listBox1.SelectedItem.ToString()).EnrollmentStaff(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.controller.FindByName(listBox1.SelectedItem.ToString()).RemandStaff(0);
        }
    }
}
