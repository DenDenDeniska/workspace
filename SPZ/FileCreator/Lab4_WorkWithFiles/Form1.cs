using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4_WorkWithFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbStatus.Text = "Ожидание действий ...";
            DirectoryInfo directory = new DirectoryInfo(@".\FilesForProject");
            if (!directory.Exists)
            {
                directory.Create();
                lbStatus.Text = "Директория успешно создана";
            }

            
        }

        private void btGenerateFile_Click(object sender, EventArgs e)
        {
            string path = @".\FilesForProject\InputData.txt";
            FileInfo file = new FileInfo(path);
            StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default);
            Random rnd = new Random();
            if (!file.Exists)
            {
                file.Create();
                lbStatus.Text = "Файл успешно создан";
            }
            else
            { 
                int rndLength = rnd.Next(1, 100);
                for (int i = 0; i < rndLength; i++)
                {
                    int rndOwnLength = rnd.Next(1, 25);
                    for (int k = 0; k < rndOwnLength; k++)
                    {
                        sw.Write(rnd.NextDouble().ToString());
                        //if (k != rndOwnLength - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();
                }
                
                sw.Close();
                lbStatus.Text = "Генерация данных завершена";
            }
        }

        private void btGenericOut_Click(object sender, EventArgs e)
        {
            string pathIn = @".\FilesForProject\InputData.txt";
            string pathOut = @".\FilesForProject\InputData.out";
            FileInfo fileInput = new FileInfo(pathIn);
            if (!fileInput.Exists)
            {
                lbStatus.Text = "Файл InputData.txt отсутствует !!!";
                return;
            }
            FileInfo fileOutput = new FileInfo(pathOut);
            if (!fileInput.Exists)
            {
                fileOutput.Create();
                lbStatus.Text = "Файл InputData.out создан";
            }
            StreamReader srInRd = new StreamReader(pathIn, System.Text.Encoding.Default);
            StreamWriter srOutWr = new StreamWriter(pathOut, false ,System.Text.Encoding.Default);
            
            string line;
            while ((line = srInRd.ReadLine()) != null)
            {
                int lineCounts = 0;
                for (int i = 0; i < line.Length; i++)
                    if (line[i] == ',')
                        lineCounts++;

                srOutWr.Write(lineCounts.ToString() + ',');
            }
            srInRd.Close();
            srOutWr.Close();

        }

        private void btOpenOutFile_Click(object sender, EventArgs e)
        {
            string pathIn = @".\FilesForProject\InputData.out";
            FileInfo fileOutput = new FileInfo(pathIn);
            if (!fileOutput.Exists)
            {
                lbStatus.Text = "Файл InputData.out не найден !!!";
                return;
            }
            StreamReader srInRd = new StreamReader(pathIn, System.Text.Encoding.Default);
            
            tbOutFile.AppendText(srInRd.ReadLine());
          
            srInRd.Close();
        }
    }
}
