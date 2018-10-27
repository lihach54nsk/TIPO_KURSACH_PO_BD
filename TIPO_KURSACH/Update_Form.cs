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
            string searchString = "SELECT * FROM dbo.Workers WHERE dbo.Workers.lastName LIKE N'{0}'";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string searchFormat = string.Format(searchString, SearchTextBox.Text);

            SqlCommand searchCommand = new SqlCommand(searchFormat, sqlConnection);

            var data = searchCommand.ExecuteReader();
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

            searchResultsDataGridView.RowCount = j;
            searchResultsDataGridView.ColumnCount = data.FieldCount;

            searchResultsDataGridView.Columns[0].Name = "ID";
            searchResultsDataGridView.Columns[1].Name = "ID_P";
            searchResultsDataGridView.Columns[2].Name = "Фамилия";
            searchResultsDataGridView.Columns[3].Name = "Имя";
            searchResultsDataGridView.Columns[4].Name = "Отчество";
            searchResultsDataGridView.Columns[5].Name = "Адрес проживания";
            searchResultsDataGridView.Columns[6].Name = "Дата рождения";

            for (int k = 0; k < j - 1; k++)
            {
                for (int i = 0; i < data.FieldCount; i++)
                {
                    searchResultsDataGridView.Rows[k].Cells[i].Value = showFormat[k].Split(Convert.ToChar(","))[i];
                }
            }

            sqlConnection.Close();
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