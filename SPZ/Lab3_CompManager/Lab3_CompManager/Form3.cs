using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3_CompManager
{
    public partial class Form3 : Form
    {

        private List<Task> MainTasks;
        public Form3()
        {
            InitializeComponent();
            MainTasks = new List<Task>();
            foreach (var element in Program.internetBar.DictionaryOfTasks)
            {
                MainTasks.Add(element.Value);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                listBox2.DataSource = Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).Tasks;
                listBox1.DataSource = MainTasks;
            if (Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).Tasks.Count != 0)
            {

                if (Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking != 0)
                {
                    progressBar1.Value = (int)Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).GetTimeMil() * 100 / Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking;
                    label1_timeNow.Text = Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).GetTime().ToString();
                    label1_devTime.Text = (Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking - (int)Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).GetTimeMil()).ToString();
                }
                else
                {
                    progressBar1.Value = 0;
                    label1_timeNow.Text = "";
                    label1_devTime.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).Tasks.Add(new Task(Program.internetBar.FindTaskByName(listBox1.SelectedItem.ToString())));
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (textBox1_Delay.Text != "")
            {
                Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking = Int32.Parse(textBox1_Delay.Text);

                Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).StartTask(Int32.Parse(textBox1_Delay.Text));

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1_Delay.Text != "")
            {
                Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).TimeOfWorking = Int32.Parse(textBox1_Delay.Text);

                Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).StartTask(Int32.Parse(textBox1_Delay.Text));

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.internetBar.FindComputerByName(Program.form1.listBox1.SelectedItem.ToString()).FindTaskByName(listBox2.SelectedItem.ToString()).StopTask();
        }
    }
}
