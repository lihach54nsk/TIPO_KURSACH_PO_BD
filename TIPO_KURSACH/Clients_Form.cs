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
    public partial class Clients_Form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Documents\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security = True";

        public Clients_Form()
        {
            InitializeComponent();

            string showComputersString = "SELECT * FROM dbo.State ORDER BY Id_WorkPlace";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string[] showFormat = new string[1000];

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(showComputersString, sqlConnection);

            var data = sqlCommand.ExecuteReader();
            int j = 1;

            while (data.Read())
            {
                IDataRecord record = data;
                showFormat[j - 1] = string.Format("{0}, {1}", record.GetValue(0).ToString(), record.GetValue(1).ToString());
                j++;
            }

            ClientsComputersDataGridView.RowCount = j;
            ClientsComputersDataGridView.ColumnCount = 2;

            ClientsComputersDataGridView.Columns[0].Name = "ID";
            ClientsComputersDataGridView.Columns[1].Name = "Состояние";

            for (int k = 0; k < j - 1; k++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 1) ClientsComputersDataGridView.Rows[k].Cells[i].Value = State(Convert.ToInt32(showFormat[k].Split(Convert.ToChar(","))[i]));
                    else ClientsComputersDataGridView.Rows[k].Cells[i].Value = showFormat[k].Split(Convert.ToChar(","))[i];
                }
            }

            sqlConnection.Close();
        }

        private void UseComputerButton_Click(object sender, EventArgs e)
        { // нужна проверка по состоянию компа
            string clientString = "INSERT INTO dbo.Clients (lastName, firstName, otchestvo) VALUES (N'{0}', N'{1}', N'{2}')";
            string useString = "UPDATE dbo.Clients_Data SET Id_client = '{0}', " +
                "dateTime_Begin = '{1}', dateTime_End = '{2}', traffic = '{3}' WHERE Id_WorkPlace = '{4}'";
            string updateState = "UPDATE dbo.State SET STATE = '1' WHERE Id_WorkPlace = '{0}'";
            string lastClientID = "SELECT IDENT_CURRENT ('dbo.Clients')";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string clientFormat = string.Format(clientString, lastNameClientTextBox.Text, firstNameClientTextBox.Text, otchestvoClientTextBox.Text);

            SqlCommand clientCommand = new SqlCommand(clientFormat, sqlConnection);

            clientCommand.ExecuteNonQuery();

            sqlConnection.Close();

            sqlConnection.Open();

            SqlCommand clientIDCommand = new SqlCommand(lastClientID, sqlConnection);

            var data = clientIDCommand.ExecuteReader();
            data.Read();
            IDataRecord record = data;

            string lastID = string.Format("{0}", record.GetValue(0).ToString());

            sqlConnection.Close();

            var IDWorkPlace = ClientsComputersDataGridView.Rows[ClientsComputersDataGridView.SelectedCells[0].RowIndex].Cells[0].Value;

            string useFormat = string.Format(useString, lastID, dateTimePickerBegin.Text, dateTimePickerEnd.Text, "0", IDWorkPlace);
            string stateFormat = string.Format(updateState, IDWorkPlace);

            sqlConnection.Open();

            SqlCommand useCommand = new SqlCommand(useFormat, sqlConnection);

            useCommand.ExecuteNonQuery();

            sqlConnection.Close();

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(stateFormat, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
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

        string State(int state)
        {
            switch (state)
            {
                case 0: return "Свободно";
                case 1: return "Занято";
                case 2: return "Ремонт";
                case 3: return "Забронировано";
            }
            return "Баг";
        }
    }
}