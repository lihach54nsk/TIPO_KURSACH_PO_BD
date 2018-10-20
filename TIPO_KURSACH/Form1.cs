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
        string connectionString =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Documents\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security = True";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string queryString = "INSERT INTO dbo.Workers (Id_position, Id_workers, lastName, firstName, otchestvo, address, date) VALUES ('1', '1', 'Пидор', 'Блэт', 'Евгеньевич', 'Подвал', '1964-08-22')";
            command.CommandText = queryString;
            command.Connection = sqlConnection;

            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            
        }
    }
}