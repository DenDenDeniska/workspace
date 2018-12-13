using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FactoryController
{
    public partial class Form1 : Form
    {
        Factory factory;
        DirectoryInfo dir = new DirectoryInfo(".\\");
        public Form1()
        {
            InitializeComponent();
            

            factory = new Factory();
            numericUpDown1.Value = factory.Manufactories;
            numericUpDown2.Value = factory.Manufactories;
            numericUpDown3.Value = factory.Manufactories;

            lb_Budget1.Text = factory.Budget.ToString();
            lb_Budget2.Text = factory.Budget.ToString();
            lb_Budget3.Text = factory.Budget.ToString();

            lbox_Reports.DataSource = dir.GetFiles("*.xml");
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            factory.Manufactories = (int)numericUpDown1.Value;
            numericUpDown2.Value = factory.Manufactories;
            numericUpDown3.Value = factory.Manufactories;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            factory.Manufactories = (int)numericUpDown2.Value;
            numericUpDown1.Value = factory.Manufactories;
            numericUpDown3.Value = factory.Manufactories;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            factory.Manufactories = (int)numericUpDown3.Value;
            numericUpDown1.Value = factory.Manufactories;
            numericUpDown2.Value = factory.Manufactories;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string info = "r:" + factory.CurrentNumberOfRawMaterial.ToString()
                + " p:" + factory.CurrentNumberOfProduction.ToString()
                + " / max:" + factory.MaxSizeOfStorage.ToString();
            
            lb_CurrentSize1.Text = info;
            lb_CurrentSize2.Text = info;
            lb_CurrentSize3.Text = info;

            lb_Budget1.Text = factory.Budget.ToString();
            lb_Budget2.Text = factory.Budget.ToString();
            lb_Budget3.Text = factory.Budget.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(factory.BuyingRaw));
            myThread.Start();
        }

        private void bt_Creating_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(factory.CreatingProduct));
            myThread.Start();
        }

        private void bt_Realize_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(new ThreadStart(factory.RealizationProduct));
            myThread.Start();
        }

        private void bt_GenReport_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Factory));
            string currenttime = DateTime.Now.Day.ToString()+
                DateTime.Now.Month.ToString()+
                DateTime.Now.Year.ToString()+
                DateTime.Now.Hour.ToString()+
                DateTime.Now.Minute.ToString()+
                DateTime.Now.Second.ToString();
            
            string FileName = currenttime +".xml";
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, factory);
            }
            lbox_Reports.DataSource = dir.GetFiles("*.xml");
        }

        private void lbox_Reports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textFromFile;
            using (FileStream fstream = File.OpenRead(((FileInfo)((ListBox)sender).SelectedValue).FullName))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                textFromFile = System.Text.Encoding.Default.GetString(array);
            }
            tb_RepInfo.Text = textFromFile;
        }

        private void lbox_Reports_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (FileStream fs = new FileStream(((ListBox)sender).SelectedItem.ToString(), FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(Factory));
                this.factory = (Factory)formatter.Deserialize(fs);
            }
            numericUpDown1.Value = factory.Manufactories;
            numericUpDown2.Value = factory.Manufactories;
            numericUpDown3.Value = factory.Manufactories;
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            //File.Delete(((FileInfo)((ListBox)sender).SelectedValue).FullName);
            lbox_Reports.DataSource = dir.GetFiles("*.xml");
        }
    }
}
