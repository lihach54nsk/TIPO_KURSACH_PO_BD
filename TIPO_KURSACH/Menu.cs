using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIPO_KURSACH
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        static Autorization autorization = new Autorization();

        public void SetAutorization(int position)
        {
            autorization.position = position;
        }

        int form = 0;

        public int GetForm() => form;

        private void WorkersButton_Click(object sender, EventArgs e)
        {
            // OK - Workers
            // Yes - Компьютеры
            // No - Клиенты

            switch (autorization.position)
            {
                case 1: // админ
                    Form1 form1 = new Form1();

                    form1.SetAutorization(autorization.position);
                    form1.Host();

                    form1.Show();
                    // Application.Run(form1);
                    break;

                case 2: // зам админа
                    Form1 form1Zam = new Form1();

                    form1Zam.SetAutorization(autorization.position);
                    form1Zam.Host();

                    form1Zam.Show();
                    //Application.Run(form1Zam);
                    break;

                case 3: // грузчик
                    MessageBox.Show("Нет доступа, позовите администратора или его заместителя");
                    break;

                case 4: // уборщик или наоборот с грузчиком
                    MessageBox.Show("Нет доступа, позовите администратора или его заместителя");
                    break;
            }
        }

        private void ComputersButton_Click(object sender, EventArgs e)
        {
            switch (autorization.position)
            {
                case 1: // админ
                    Computers_Form computers_Form = new Computers_Form();

                    computers_Form.SetAutorization(autorization.position);

                    computers_Form.Show();
                    // Application.Run(computers_Form);
                    break;

                case 2: // зам админа
                    Computers_Form computers_FormZam = new Computers_Form();

                    computers_FormZam.SetAutorization(autorization.position);

                    computers_FormZam.Show();
                    //Application.Run(computers_FormZam);
                    break;

                case 3: // грузчик
                    MessageBox.Show("Нет доступа, позовите администратора или его заместителя");
                    break;

                case 4: // уборщик или наоборот с грузчиком
                    MessageBox.Show("Нет доступа, позовите администратора или его заместителя");
                    break;
            }
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            switch (autorization.position)
            {
                case 1: // админ
                    Clients_Form clients_Form = new Clients_Form();

                    clients_Form.SetAutorization(autorization.position);

                    clients_Form.Show();
                    // Application.Run(clients_Form);
                    break;

                case 2: // зам админа
                    Clients_Form clients_FormZam = new Clients_Form();

                    clients_FormZam.SetAutorization(autorization.position);

                    clients_FormZam.Show();
                    //Application.Run(clients_FormZam);
                    break;

                case 3: // грузчик
                    MessageBox.Show("Нет доступа, позовите администратора или его заместителя");
                    break;

                case 4: // уборщик или наоборот с грузчиком
                    MessageBox.Show("Нет доступа, позовите администратора или его заместителя");
                    break;
            }
        }
    }
}