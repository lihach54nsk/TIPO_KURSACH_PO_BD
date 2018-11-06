﻿using System;
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
        string connectionString = Autorization.GetConnectionString();

        public Clients_Form()
        {
            InitializeComponent();

            string showComputersString = "SELECT * FROM dbo.State ORDER BY Id_WorkPlace";
            string showComputersTime = "SELECT * FROM dbo.Clients_Data WHERE Id_client<>-1 ORDER BY Id_WorkPlace";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string[] showFormat = new string[1000];
            string[] dateTimeFormat = new string[1000];

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

            sqlConnection.Close();

            sqlConnection.Open();

            SqlCommand dateTimeCommand = new SqlCommand(showComputersTime, sqlConnection);

            var dateTime = dateTimeCommand.ExecuteReader();

            int t = 0;
            while (dateTime.Read())
            {
                IDataRecord dataRecord = dateTime;
                dateTimeFormat[t] = string.Format("{0}, {1}", dataRecord.GetValue(0).ToString(), dataRecord.GetValue(3).ToString());
                t++;
            }

            sqlConnection.Close();

            ClientsComputersDataGridView.RowCount = j;
            ClientsComputersDataGridView.ColumnCount = 3;

            ClientsComputersDataGridView.Columns[0].Name = "ID";
            ClientsComputersDataGridView.Columns[1].Name = "Состояние";
            ClientsComputersDataGridView.Columns[2].Name = "Занят/бронь до";

            for (int k = 0; k < j - 1; k++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 1)
                    {
                        ClientsComputersDataGridView.Rows[k].Cells[i].Value = State(Convert.ToInt32(showFormat[k].Split(Convert.ToChar(","))[i]));
                    }
                    else
                    {
                        ClientsComputersDataGridView.Rows[k].Cells[i].Value = showFormat[k].Split(Convert.ToChar(","))[i];
                        int y = 0;
                        while (dateTimeFormat[y] != null)
                        {
                            if (dateTimeFormat[y].Split(Convert.ToChar(","))[0] == ClientsComputersDataGridView.Rows[k].Cells[i].Value.ToString())
                            {
                                ClientsComputersDataGridView.Rows[k].Cells[2].Value = dateTimeFormat[y].Split(Convert.ToChar(","))[1]; break;
                            }
                            y++;
                        }
                    }
                }
            }
        }

        private void UseComputerButton_Click(object sender, EventArgs e)
        {
            var IDWorkPlace = ClientsComputersDataGridView.Rows[ClientsComputersDataGridView.SelectedCells[0].RowIndex].Cells[0].Value;
            string checkQuery = "SELECT * FROM dbo.State WHERE Id_WorkPlace = '{0}'";

            string checkFormat = string.Format(checkQuery, IDWorkPlace);

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand checkCommand = new SqlCommand(checkFormat, sqlConnection);

            var checkData = checkCommand.ExecuteReader();
            checkData.Read();
            IDataRecord check = checkData;

            if (check.GetValue(1).ToString() == "0")
            {
                sqlConnection.Close();

                string clientString = "INSERT INTO dbo.Clients (lastName, firstName, otchestvo) VALUES (N'{0}', N'{1}', N'{2}')";
                string useString = "UPDATE dbo.Clients_Data SET Id_client = '{0}', " +
                    "dateTime_Begin = '{1}', dateTime_End = '{2}', traffic = '{3}' WHERE Id_WorkPlace = '{4}'";
                string updateState = "UPDATE dbo.State SET STATE = '1' WHERE Id_WorkPlace = '{0}'";
                string lastClientID = "SELECT IDENT_CURRENT ('dbo.Clients')";

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
            else sqlConnection.Close();
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string showComputersString = "SELECT * FROM dbo.State ORDER BY Id_WorkPlace";
            string showComputersTime = "SELECT * FROM dbo.Clients_Data WHERE Id_client<>-1 ORDER BY Id_WorkPlace";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string[] showFormat = new string[1000];
            string[] dateTimeFormat = new string[1000];

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

            sqlConnection.Close();

            sqlConnection.Open();

            SqlCommand dateTimeCommand = new SqlCommand(showComputersTime, sqlConnection);

            var dateTime = dateTimeCommand.ExecuteReader();

            int t = 0;
            while (dateTime.Read())
            {
                IDataRecord dataRecord = dateTime;
                dateTimeFormat[t] = string.Format("{0}, {1}", dataRecord.GetValue(0).ToString(), dataRecord.GetValue(3).ToString());
                t++;
            }

            sqlConnection.Close();

            ClientsComputersDataGridView.RowCount = j;
            ClientsComputersDataGridView.ColumnCount = 3;

            ClientsComputersDataGridView.Columns[0].Name = "ID";
            ClientsComputersDataGridView.Columns[1].Name = "Состояние";
            ClientsComputersDataGridView.Columns[2].Name = "Занят/бронь до";

            for (int k = 0; k < j - 1; k++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 1)
                    {
                        ClientsComputersDataGridView.Rows[k].Cells[i].Value = State(Convert.ToInt32(showFormat[k].Split(Convert.ToChar(","))[i]));
                    }
                    else
                    {
                        ClientsComputersDataGridView.Rows[k].Cells[i].Value = showFormat[k].Split(Convert.ToChar(","))[i];
                        int y = 0;
                        while (dateTimeFormat[y] != null)
                        {
                            if (dateTimeFormat[y].Split(Convert.ToChar(","))[0] == ClientsComputersDataGridView.Rows[k].Cells[i].Value.ToString())
                            {
                                ClientsComputersDataGridView.Rows[k].Cells[2].Value = dateTimeFormat[y].Split(Convert.ToChar(","))[1]; break;
                            }
                            y++;
                        }
                    }
                }
            }
        }
    }
}