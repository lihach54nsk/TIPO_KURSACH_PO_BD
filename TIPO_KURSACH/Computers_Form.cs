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
    public partial class Computers_Form : Form
    {
        string connectionString = Autorization.GetConnectionString();

        Autorization autorization = new Autorization();

        public void SetAutorization(int positionID)
        {
            autorization.position = positionID;
        }

        public Computers_Form()
        {
            InitializeComponent();
        }

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            Add_Computer_Form add_Computer_Form = new Add_Computer_Form();

            add_Computer_Form.Show();
        }

        private void DeleteComputerButton_Click(object sender, EventArgs e)
        {
            string queryString = "DELETE FROM dbo.PC_O WHERE Id_WorkPlace = '{0}'";
            string queryStateString = "DELETE FROM dbo.State WHERE Id_WorkPlace = '{0}'";
            string queryMoneyString = "DELETE FROM dbo.workPlace_Receips WHERE Id_WorkPlace = '{0}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            var ID = ComputersDataGridView.Rows[ComputersDataGridView.SelectedCells[0].RowIndex].Cells[0].Value;

            string deleteFormat = string.Format(queryString, ID);
            string deleteStateFormat = string.Format(queryStateString, ID);
            string deleteMoneyFormat = string.Format(queryMoneyString, ID);

            Sure_Form sure_Form = new Sure_Form();

            if (sure_Form.ShowDialog() == DialogResult.Yes)
            {
                sqlConnection.Open();

                SqlCommand deleteCommand = new SqlCommand(deleteFormat, sqlConnection);

                deleteCommand.ExecuteNonQuery();

                sqlConnection.Close();

                sqlConnection.Open();

                SqlCommand deleteStateCommand = new SqlCommand(deleteStateFormat, sqlConnection);

                deleteStateCommand.ExecuteNonQuery();

                sqlConnection.Close();

                sqlConnection.Open();

                SqlCommand deleteMoneyCommand = new SqlCommand(deleteMoneyFormat, sqlConnection);

                deleteMoneyCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void ShowComputersButton_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM dbo.PC_O" +
                                  " JOIN dbo.Peref ON dbo.PC_O.Id_Peref = dbo.Peref.Id_Peref" +
                                  " JOIN dbo.State_of_PC ON dbo.PC_O.Id_PC = dbo.State_of_PC.Id_PC" +
                                  " JOIN dbo.state_of_PS ON dbo.PC_O.Id_PS = dbo.state_of_PS.Id_PS" + " ORDER BY Id_WorkPlace";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string[] showFormat = new string[1000];

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(queryString, sqlConnection);

            var data = sqlCommand.ExecuteReader();
            int j = 1;

            while (data.Read())
            {
                IDataRecord record = data;

                showFormat[j - 1] = string.Format("{0}% {1}% {2}% {3}", record.GetValue(0).ToString(),
                    record.GetValue(5).ToString(),
                    record.GetValue(7).ToString(),
                    record.GetValue(9).ToString());
                    j++;
            }

            ComputersDataGridView.RowCount = j;
            ComputersDataGridView.ColumnCount = 4;

            ComputersDataGridView.Columns[0].Name = "ID компьютера";
            ComputersDataGridView.Columns[1].Name = "Периферия";
            ComputersDataGridView.Columns[2].Name = "Комплектующие";
            ComputersDataGridView.Columns[3].Name = "ПО";

            for (int k = 0; k < j - 1; k++)
            {
                for (int i = 0; i < 4; i++)
                    ComputersDataGridView.Rows[k].Cells[i].Value = showFormat[k].Split(Convert.ToChar("%"))[i];
            }

            sqlConnection.Close();
        }
    }
}