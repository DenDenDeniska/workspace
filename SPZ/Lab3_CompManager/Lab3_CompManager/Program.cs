using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CompManager
{
    static class Program
    {
        // определение екземпляра интернет-бара
        internal static Manager internetBar;
        //определение формы, доступной только в текущей сборке
        internal static Form1 form1;
        //Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            //Создание экземпляра интернет-бара
            internetBar = new Manager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(form1 = new Form1());
            
        }
    }
}
