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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.DataSource = Program.internetBar.Computers;
           

            
            Program.internetBar.DictionaryOfTasks.Add(0, new Task("Майнинг биткоинов"));
            Program.internetBar.DictionaryOfTasks.Add(1, new Task("Просмотр аниме"));
            Program.internetBar.DictionaryOfTasks.Add(2, new Task("Рубиловка в Mortal Kombat"));
            Program.internetBar.DictionaryOfTasks.Add(3, new Task("Просмотр сериальчиков"));
            Program.internetBar.DictionaryOfTasks.Add(4, new Task("Залипание в Yuotube"));
            Program.internetBar.DictionaryOfTasks.Add(5, new Task("PornHUB"));
            Program.internetBar.DictionaryOfTasks.Add(6, new Task("CSGO"));
            Program.internetBar.DictionaryOfTasks.Add(7, new Task("DOTA 2"));
            Program.internetBar.DictionaryOfTasks.Add(8, new Task("S.T.A.L.K.E.R."));

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4_NetworkStatus.Text = Program.internetBar.Wifi.ToString();
            if (Program.internetBar.Wifi == true) { button3_TrNetw.Text = "Выключить"; }
            else button3_TrNetw.Text = "Включить";
            if (Program.internetBar.Computers.Count != 0)
            {
                listBox2.DataSource = Program.internetBar.FindComputer(listBox1.SelectedItem.ToString()).Tasks;
                

                if (Program.internetBar.FindComputer(Program.form1.listBox1.SelectedItem.ToString()).Tasks.Count != 0)
                {
                    if (Program.internetBar.FindComputer(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking != 0)
                        progressBar1.Value = (int)Program.internetBar.FindComputer(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).GetTimeMil() * 100 / Program.internetBar.FindComputer(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking;
                    else
                        progressBar1.Value = 0;
                }
            }
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Program.internetBar.Computers.Count > 0)
            { 
                Form3 newForm = new Form3();
                newForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.internetBar.Computers.Count > 0) 
                Program.internetBar.Computers.Remove(Program.internetBar.FindComputer(listBox1.SelectedItem.ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Program.internetBar.Wifi == false)
            {
                Program.internetBar.EnableWiFi(textBox1_Pass.Text);
                textBox1_Pass.Text = "";
            }
            else
            {
                Program.internetBar.DisableWiFi(textBox1_Pass.Text);
                textBox1_Pass.Text = "";
            }


        }

        private void button3_Equals_Click(object sender, EventArgs e)
        {
            if (textBox_PC1.Text != "" || textBox_PC2.Text != "")
            {
                Computer computer1 = new Computer(Program.internetBar.FindComputer(textBox_PC1.Text));
                Computer computer2 = new Computer(Program.internetBar.FindComputer(textBox_PC2.Text));
                if (computer1 == computer2)
                    label_Equals.Text = "Равны";
                else
                    label_Equals.Text = "Не равны";
            }
        }
    }
}
