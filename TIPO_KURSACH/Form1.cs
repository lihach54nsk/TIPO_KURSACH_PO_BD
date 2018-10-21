using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TIPO_KURSACH
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Documents\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO dbo.Workers (Id_position, Id_workers, lastName, firstName, otchestvo, address, date) " +
                "VALUES ('1', '1', '{0}', '{1}', '{2}', '{3}', '{4}')";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string instCom = string.Format(queryString, lastNameTextBox.Text, firstNameTextBox.Text, otchestvoTextBox.Text, addressTextBox.Text, date_BirthTextBox.Text);

            SqlCommand command = new SqlCommand(instCom, sqlConnection);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {

        }
    }
}