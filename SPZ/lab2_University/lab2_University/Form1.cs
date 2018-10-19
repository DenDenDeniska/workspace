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
            if(Program.controller.RemoveUniversity(University_Name.Text) == true)
            {
                label4.Text = "Университет " + University_Name.Text + " удален .";
            }
            else
            {
                label4.Text = "Университет " + University_Name.Text +" не найден в базе";
            }
            
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
                listBox3.DataSource = Program.controller.FindByName(listBox1.SelectedItem.ToString()).Labs;
            }

        }
    }
}
