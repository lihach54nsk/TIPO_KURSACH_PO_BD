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
            sqlConnection.Open();
            string queryString = "INSERT INTO dbo.Workers (Id_position, Id_workers, lastName, firstName, otchestvo, address, date)" +
                " VALUES ('1', '1', @last, @first, @otch, @addr, @dat)";
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connectionString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder();

            string last,first, otch, addr, dat;
            last = lastNameTextBox.Text.ToString(); first = firstNameTextBox.Text.ToString();otch = otchestvoTextBox.Text.ToString(); addr = addressTextBox.Text.ToString(); dat = date_BirthTextBox.Text.ToString();

            adapter.Fill(dataSet);  
            
            adapter.InsertCommand=new SqlCommand()

            sqlConnection.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            
        }
    }
}