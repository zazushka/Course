using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 42. Справочник нумизмата. 
        /// Монеты: страна, номинал, год выпуска, количество выпущенных монет, особенности. 
        /// Коллекционеры: страна, имя, контактные координаты, наличие редких монет в коллекции. 
        /// Собственная коллекция.
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
