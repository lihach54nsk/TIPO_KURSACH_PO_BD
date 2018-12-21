using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIPO_KURSACH
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        static Autorization autorization = new Autorization();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //while (true)
            //{
                Menu menu = new Menu();

                Autorization_Form autorization_Form = new Autorization_Form();
                Application.Run(autorization_Form);
                autorization.position = autorization_Form.GetPositionID();

                if (autorization.position != 0)
                {
                    menu.SetAutorization(autorization.position);
                    Application.Run(menu);
                }
            //}
        }
    }
}