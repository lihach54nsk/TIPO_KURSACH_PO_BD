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
            string updateString = "UPDATE dbo.Workers SET Id_position = '{0}', lastName = N'{1}', firstName = N'{2}', otchestvo = N'{3}', address = N'{4}', date = '{5}' WHERE Id_position = '1'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string updateFormat = string.Format(updateString, positionSearchTextBox.Text, lastNameSearchTextBox.Text, firstNameSearchTextBox.Text, otchestvoSearchTextBox.Text, addressSearchTextBox.Text, date_BirthSearchTextBox.Text);

            SqlCommand command = new SqlCommand(updateFormat, sqlConnection);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}