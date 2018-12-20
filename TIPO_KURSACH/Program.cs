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

            while (true)
            {
                int form = 0;
                //Menu menu = new Menu();
                //Application.Run(menu);
                //form = menu.GetForm();

                Autorization_Form autorization_Form = new Autorization_Form();
                Application.Run(autorization_Form);
                autorization.position = autorization_Form.GetPositionID();

                switch (autorization.position)
                {
                    case 1: // админ
                        Form1 form1 = new Form1();
                        Computers_Form computers_Form = new Computers_Form();
                        Clients_Form clients_Form = new Clients_Form();

                        form1.SetAutorization(autorization.position);
                        form1.Host();
                        computers_Form.SetAutorization(autorization.position);
                        clients_Form.SetAutorization(autorization.position);

                        Application.Run(form1);
                        Application.Run(computers_Form);
                        Application.Run(clients_Form);
                        break;

                    case 2: // зам админа
                        Form1 form1Zam = new Form1();
                        Computers_Form computers_FormZam = new Computers_Form();
                        Clients_Form clients_FormZam = new Clients_Form();

                        form1Zam.SetAutorization(autorization.position);
                        form1Zam.Host();
                        computers_FormZam.SetAutorization(autorization.position);
                        clients_FormZam.SetAutorization(autorization.position);

                        Application.Run(form1Zam);
                        Application.Run(computers_FormZam);
                        Application.Run(clients_FormZam);
                        break;

                    case 3: // грузчик
                        MessageBox.Show("Нет доступа, зови админа или его зама");
                        break;

                    case 4: // уборщик или наоборот с грузчиком
                        MessageBox.Show("Нет доступа, зови админа или его зама");
                        break;
                }
            }
        }
    }
}