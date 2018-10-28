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

            string queryString = "SELECT * FROM dbo.Positions ORDER BY Id_position";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            var data = command.ExecuteReader();
            string[] comboFormat = new string[100];
            int j = 1;

            while (data.Read())
            {
                IDataRecord record = data;

                comboFormat[j - 1] = string.Format("{0}", record.GetValue(1).ToString());
                j++;
            }

            sqlConnection.Close();

            int i = 0;

            while (comboFormat[i] != null)
            {
                PositionComboBox.Items.Add(comboFormat[i].ToString()); i++;
            }
        }
                
        private void button_Add_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO dbo.Workers (Id_position, lastName, firstName, otchestvo, address, date) " +
                "VALUES ('{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}')";
            string queryPositionString = "SELECT * FROM dbo.Positions WHERE Position = N'{0}'";
            //SELECT * FROM dbo.Positions WHERE Position = N'Администратор'

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string positionFormat = string.Format(queryPositionString, PositionComboBox.Text);

            SqlCommand positionCommand = new SqlCommand(positionFormat, sqlConnection);

            var data = positionCommand.ExecuteReader();
            data.Read();
            IDataRecord record = data;

            string idPosition = string.Format("{0}", record.GetValue(0).ToString());

            sqlConnection.Close();

            sqlConnection.Open();

            string insertFormat = string.Format(queryString, idPosition, lastNameTextBox.Text, firstNameTextBox.Text, otchestvoTextBox.Text, addressTextBox.Text, date_BirthTextBox.Text);

            SqlCommand command = new SqlCommand(insertFormat, sqlConnection);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM dbo.Workers ORDER BY Id_position";
            
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand command = new SqlCommand(queryString, sqlConnection);

            var data = command.ExecuteReader();
            string[] showFormat = new string[10000];
            int j = 1;

            while (data.Read())
            {
                IDataRecord record = data;

                showFormat[j - 1] = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                        record.GetValue(0).ToString(), record.GetValue(1).ToString(), record.GetValue(2).ToString(),
                        record.GetValue(3).ToString(), record.GetValue(4).ToString(), record.GetValue(5).ToString(),
                        record.GetValue(6).ToString());
                j++;
            }

            dataGridViewShow.RowCount = j;
            dataGridViewShow.ColumnCount = data.FieldCount;

            dataGridViewShow.Columns[0].Name = "ID";
            dataGridViewShow.Columns[1].Name = "ID_P";
            dataGridViewShow.Columns[2].Name = "Фамилия";
            dataGridViewShow.Columns[3].Name = "Имя";
            dataGridViewShow.Columns[4].Name = "Отчество";
            dataGridViewShow.Columns[5].Name = "Адрес проживания";
            dataGridViewShow.Columns[6].Name = "Дата рождения";

            for (int k = 0; k < j - 1; k++)
            {
                for (int i = 0; i < data.FieldCount; i++)
                {
                    dataGridViewShow.Rows[k].Cells[i].Value = showFormat[k].Split(Convert.ToChar(","))[i];
                }
            }

            sqlConnection.Close();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            Update_Form update_Form = new Update_Form();

            update_Form.Show();
        }
    }
}