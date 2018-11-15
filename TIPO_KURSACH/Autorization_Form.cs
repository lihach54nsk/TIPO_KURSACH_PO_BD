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
    public partial class Autorization_Form : Form
    {
        string connectionString = Autorization.GetConnectionString();

        public Autorization_Form()
        {
            InitializeComponent();

            string comboBoxString = "SELECT Id_position, lastName, firstName, otchestvo FROM dbo.Workers";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string[] comboBoxStringFormat = new string[100];

            sqlConnection.Open();

            SqlCommand comboBoxCommand = new SqlCommand(comboBoxString, sqlConnection);

            var data = comboBoxCommand.ExecuteReader();
            int j = 0;
            while (data.Read())
            {
                IDataRecord record = data;
                comboBoxStringFormat[j] = string.Format("{0}%{1}%{2}%{3}", record.GetValue(0).ToString(), record.GetValue(1).ToString(), record.GetValue(2).ToString(),record.GetValue(3).ToString());
                j++;
            }
            sqlConnection.Close();

            int i = 0;
            while (comboBoxStringFormat[i] != null)
            {
                SignInComboBox.Items.Add((comboBoxStringFormat[i].Split(Convert.ToChar("%"))[0].ToString() + " - " 
                    + comboBoxStringFormat[i].Split(Convert.ToChar("%"))[1].ToString() + " " 
                    + comboBoxStringFormat[i].Split(Convert.ToChar("%"))[2].ToString() + " "
                    + comboBoxStringFormat[i].Split(Convert.ToChar("%"))[3].ToString()).ToString());
                i++;
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string singInString = "SELECT * FROM dbo.Autorization WHERE Id_workers = '{0}'";

            string signInStringFormat = string.Format(singInString, SignInComboBox.Text.Split(Convert.ToChar(" "))[0].ToString());

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(signInStringFormat, sqlConnection);

            var data = sqlCommand.ExecuteReader();
            data.Read();
            IDataRecord record = data;

            var hash = record.GetValue(1).ToString();

            sqlConnection.Close();

            if (PasswordTextBox.Text.GetHashCode() == Convert.ToInt32(hash)) MessageBox.Show("Успешно");
            else MessageBox.Show("Ты - пидор!");
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        { 

        }
    }
}