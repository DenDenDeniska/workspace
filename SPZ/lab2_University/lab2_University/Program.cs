using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_University
{

    static class Program
    {
       
        public static Controller controller = new Controller();
        private static readonly string str = "Hello, World !";//традиция, данная строчка не обсуждается
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
            
        }
    }
   
}
