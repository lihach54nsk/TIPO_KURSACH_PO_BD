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
    public partial class Update_Form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Documents\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security = True";

        public Update_Form()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void EditTextBox_Click(object sender, EventArgs e)
        {
            string queryString = "UPDATE dbo.Workers SET Id_position = '1', lastName = N'Я', firstName = N'ЕСТЬ', otchestvo = N'ГРУТ', address = N'ДУПЛО', date = '2222-02-02' WHERE Id_position = '1'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}