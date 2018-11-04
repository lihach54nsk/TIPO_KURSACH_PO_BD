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
    public partial class Clients_Form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Documents\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security = True";

        public Clients_Form()
        {
            InitializeComponent();

            string showComputersString = "SELECT * FROM dbo.State ORDER BY Id_WorkPlace";


        }

        private void UseComputerButton_Click(object sender, EventArgs e)
        {

        }

        private void ReserveComputerButton_Click(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteReserveComputerButton_Click(object sender, EventArgs e)
        {

        }
    }
}