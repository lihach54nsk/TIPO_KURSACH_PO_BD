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
    public partial class Add_Computer_Form : Form
    {
        string connectionString = Autorization.GetConnectionString();

        public Add_Computer_Form()
        {
            InitializeComponent();

            string PerefString = "SELECT * FROM dbo.Peref ORDER BY Id_Peref";
            string PCString = "SELECT * FROM dbo.State_of_PC ORDER BY Id_PC";
            string PSString = "SELECT * FROM dbo.state_of_PS ORDER BY Id_PS";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlCommand Perefcommand = new SqlCommand(PerefString, sqlConnection);

            var data = Perefcommand.ExecuteReader();
            string[] comboFormatPeref = new string[100];
            int j = 1;

            while (data.Read())
            {
                IDataRecord record = data;
                comboFormatPeref[j - 1] = string.Format("{0}", record.GetValue(1).ToString());
                j++;
            }

            sqlConnection.Close();

            int i = 0;

            while (comboFormatPeref[i] != null)
            {
                PerefComboBox.Items.Add(comboFormatPeref[i].ToString()); i++;
            }

            j = 1;
            i = 0;
            string[] comboFormatPC = new string[100];

            sqlConnection.Open();

            SqlCommand commandPC = new SqlCommand(PCString, sqlConnection);

            data = commandPC.ExecuteReader();

            while (data.Read())
            {
                IDataRecord record = data;
                comboFormatPC[j - 1] = string.Format("{0}", record.GetValue(1).ToString());
                j++;
            }

            sqlConnection.Close();

            while (comboFormatPC[i] != null)
            {
                PC_ComboBox.Items.Add(comboFormatPC[i].ToString()); i++;
            }

            j = 1;
            i = 0;
            string[] comboFormatPS = new string[100];

            sqlConnection.Open();

            SqlCommand commandPS = new SqlCommand(PSString, sqlConnection);

            data = commandPS.ExecuteReader();

            while (data.Read())
            {
                IDataRecord record = data;
                comboFormatPS[j - 1] = string.Format("{0}", record.GetValue(1).ToString());
                j++;
            }

            sqlConnection.Close();

            while (comboFormatPS[i] != null)
            {
                PS_ComboBox.Items.Add(comboFormatPS[i].ToString()); i++;
            }
        }

        private void AddPerefButton_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO dbo.Peref (Peref_Data) VALUES (N'{0}')";
            string repeatString = "SELECT * FROM dbo.Peref WHERE Peref_Data = N'{0}'"; // ищем повторы

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            sqlConnection.Open();

            MessageBox.Show("Введите периферию");

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string searchFormat = string.Format(repeatString, add_Change_Form.Data());

                SqlCommand searchRepeatCommand = new SqlCommand(searchFormat, sqlConnection);

                var search = searchRepeatCommand.ExecuteReader();

                if (search.Read())
                {
                    Exist_Form exist_Form = new Exist_Form();
                    if (exist_Form.ShowDialog(this) == DialogResult.OK)
                    { exist_Form.Dispose(); sqlConnection.Close(); }
                }
                else
                {
                    sqlConnection.Close();
                    sqlConnection.Open();
                    string addFormat = string.Format(queryString, add_Change_Form.Data());
                    add_Change_Form.Dispose();

                    SqlCommand command = new SqlCommand(addFormat, sqlConnection);

                    command.ExecuteNonQuery();
                }
            }
            else add_Change_Form.Dispose();

            sqlConnection.Close();
        }

        private void AddPC_Button_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO dbo.State_of_PC (PC_Data) VALUES (N'{0}')";
            string repeatString = "SELECT * FROM dbo.State_of_PC WHERE PC_Data = N'{0}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            sqlConnection.Open();

            MessageBox.Show("Введите характеристики компьютера");

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string searchFormat = string.Format(repeatString, add_Change_Form.Data());

                SqlCommand searchRepeatCommand = new SqlCommand(searchFormat, sqlConnection);

                var search = searchRepeatCommand.ExecuteReader();

                if (search.Read())
                {
                    Exist_Form exist_Form = new Exist_Form();
                    if (exist_Form.ShowDialog(this) == DialogResult.OK)
                    { exist_Form.Dispose(); sqlConnection.Close(); }
                }
                else
                {
                    sqlConnection.Close();
                    sqlConnection.Open();
                    string addFormat = string.Format(queryString, add_Change_Form.Data());
                    add_Change_Form.Dispose();

                    SqlCommand command = new SqlCommand(addFormat, sqlConnection);

                    command.ExecuteNonQuery();
                }
            }
            else add_Change_Form.Dispose();

            sqlConnection.Close();
        }

        private void AddPS_Button_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO dbo.state_of_PS (PS) VALUES (N'{0}')";
            string repeatString = "SELECT * FROM dbo.state_of_PS WHERE PS = N'{0}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            sqlConnection.Open();

            MessageBox.Show("Введите ПО");

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string searchFormat = string.Format(repeatString, add_Change_Form.Data());

                SqlCommand searchRepeatCommand = new SqlCommand(searchFormat, sqlConnection);

                var search = searchRepeatCommand.ExecuteReader();

                if (search.Read())
                {
                    Exist_Form exist_Form = new Exist_Form();
                    if (exist_Form.ShowDialog(this) == DialogResult.OK)
                    {
                        exist_Form.Dispose(); sqlConnection.Close();
                    }
                }
                else
                {
                    sqlConnection.Close();
                    sqlConnection.Open();
                    string addFormat = string.Format(queryString, add_Change_Form.Data());
                    add_Change_Form.Dispose();

                    SqlCommand command = new SqlCommand(addFormat, sqlConnection);

                    command.ExecuteNonQuery();
                }
            }
            else add_Change_Form.Dispose();

            sqlConnection.Close();
        }

        private void ChangePerefButton_Click(object sender, EventArgs e)
        {
            string SearchIDString = "SELECT * FROM dbo.Peref WHERE Peref_data = N'{0}'";
            string updateString = "UPDATE dbo.Peref SET Peref_Data = N'{0}' WHERE Id_Peref = '{1}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string searchString = string.Format(SearchIDString, PerefComboBox.Text);

            sqlConnection.Open();

            SqlCommand searchIDCommand = new SqlCommand(searchString, sqlConnection);

            var data = searchIDCommand.ExecuteReader();
            data.Read();
            IDataRecord record = data;

            string IDString = string.Format("{0}", record.GetValue(0).ToString());

            sqlConnection.Close();

            sqlConnection.Open();

            MessageBox.Show("Введите периферию");

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string PerefFormat = string.Format(updateString, add_Change_Form.Data(), IDString);

                SqlCommand PerefCommand = new SqlCommand(PerefFormat, sqlConnection);

                PerefCommand.ExecuteNonQuery();
            }

            sqlConnection.Close();
        }

        private void ChangePC_Button_Click(object sender, EventArgs e)
        {
            string SearchIDString = "SELECT * FROM dbo.State_of_PC WHERE PC_data = N'{0}'";
            string updateString = "UPDATE dbo.State_of_PC SET PC_Data = N'{0}' WHERE Id_PC = '{1}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string searchString = string.Format(SearchIDString, PC_ComboBox.Text);

            sqlConnection.Open();

            SqlCommand searchIDCommand = new SqlCommand(searchString, sqlConnection);

            var data = searchIDCommand.ExecuteReader();
            data.Read();
            IDataRecord record = data;

            string IDString = string.Format("{0}", record.GetValue(0).ToString());

            sqlConnection.Close();

            sqlConnection.Open();

            MessageBox.Show("Введите характеристики компьютера");

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string PerefFormat = string.Format(updateString, add_Change_Form.Data(), IDString);

                SqlCommand PerefCommand = new SqlCommand(PerefFormat, sqlConnection);

                PerefCommand.ExecuteNonQuery();
            }

            sqlConnection.Close();
        }

        private void ChangePS_Button_Click(object sender, EventArgs e)
        {
            string SearchIDString = "SELECT * FROM dbo.state_of_PS WHERE PS = N'{0}'";
            string updateString = "UPDATE dbo.state_of_PS SET PS = N'{0}' WHERE Id_PS = '{1}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string searchString = string.Format(SearchIDString, PS_ComboBox.Text);

            sqlConnection.Open();

            SqlCommand searchIDCommand = new SqlCommand(searchString, sqlConnection);

            var data = searchIDCommand.ExecuteReader();
            data.Read();
            IDataRecord record = data;

            string IDString = string.Format("{0}", record.GetValue(0).ToString());

            sqlConnection.Close();

            sqlConnection.Open();

            MessageBox.Show("Введите ПО");

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string PerefFormat = string.Format(updateString, add_Change_Form.Data(), IDString);

                SqlCommand PerefCommand = new SqlCommand(PerefFormat, sqlConnection);

                PerefCommand.ExecuteNonQuery();
            }

            sqlConnection.Close();
        }

        private void DeletePerefButton_Click(object sender, EventArgs e)
        {
            Sure_Form sure_Form = new Sure_Form();

            if (sure_Form.ShowDialog() == DialogResult.Yes)
            {
                string deleteString = "DELETE FROM dbo.Peref WHERE Peref_data = N'{0}'";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string deleteFormat = string.Format(deleteString, PerefComboBox.Text);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(deleteFormat, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void DeletePC_Button_Click(object sender, EventArgs e)
        {
            Sure_Form sure_Form = new Sure_Form();

            if (sure_Form.ShowDialog() == DialogResult.Yes)
            {
                string deleteString = "DELETE FROM dbo.State_of_PC WHERE PC_Data = N'{0}'";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string deleteFormat = string.Format(deleteString, PC_ComboBox.Text);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(deleteFormat, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void DeletePS_Button_Click(object sender, EventArgs e)
        {
            Sure_Form sure_Form = new Sure_Form();

            if (sure_Form.ShowDialog() == DialogResult.Yes)
            {
                string deleteString = "DELETE FROM dbo.state_of_PS WHERE PS = N'{0}'";

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                string deleteFormat = string.Format(deleteString, PS_ComboBox.Text);

                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(deleteFormat, sqlConnection);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            string addComputerString = "INSERT INTO dbo.PC_O (Id_Peref, Id_PC, Id_PS) VALUES ('{0}', '{1}', '{2}')";
            string addWorkPlaceString = "INSERT INTO dbo.Clients_Data (Id_WorkPlace) VALUES ('{0}')";

            string SearchIDPerefString = "SELECT * FROM dbo.Peref WHERE Peref_data = N'{0}'";
            string SearchIDPCString = "SELECT * FROM dbo.State_of_PC WHERE PC_data = N'{0}'";
            string SearchIDPSString = "SELECT * FROM dbo.state_of_PS WHERE PS = N'{0}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            MessageBox.Show("Введите стоимость работы за час");

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string money = add_Change_Form.Data();

                sqlConnection.Open();

                string searchString = string.Format(SearchIDPerefString, PerefComboBox.Text);

                SqlCommand searchIDPerefCommand = new SqlCommand(searchString, sqlConnection);

                var data = searchIDPerefCommand.ExecuteReader();
                data.Read();
                IDataRecord record = data;

                string Id_Peref = string.Format("{0}", record.GetValue(0).ToString());

                sqlConnection.Close();

                sqlConnection.Open();

                searchString = string.Format(SearchIDPCString, PC_ComboBox.Text);

                SqlCommand searchIDPCCommand = new SqlCommand(searchString, sqlConnection);

                data = searchIDPCCommand.ExecuteReader();
                data.Read();
                record = data;

                string Id_PC = string.Format("{0}", record.GetValue(0).ToString());

                sqlConnection.Close();

                sqlConnection.Open();

                searchString = string.Format(SearchIDPSString, PS_ComboBox.Text);

                SqlCommand searchIDPSCommand = new SqlCommand(searchString, sqlConnection);

                data = searchIDPSCommand.ExecuteReader();
                data.Read();
                record = data;

                string Id_PS = string.Format("{0}", record.GetValue(0).ToString());

                sqlConnection.Close();

                string insertFormat = string.Format(addComputerString, Id_Peref, Id_PC, Id_PS);

                sqlConnection.Open();

                SqlCommand insertCommand = new SqlCommand(insertFormat, sqlConnection);

                insertCommand.ExecuteNonQuery();

                sqlConnection.Close();

                sqlConnection.Open();

                string lastIDString = "SELECT IDENT_CURRENT('dbo.PC_O')";

                SqlCommand lastIDCommand = new SqlCommand(lastIDString, sqlConnection);

                var dataLastID = lastIDCommand.ExecuteReader();
                dataLastID.Read();
                IDataRecord IDRecord = dataLastID;

                string lastID = string.Format("{0}", IDRecord.GetValue(0).ToString());

                sqlConnection.Close();

                string insertState = "INSERT INTO dbo.State (Id_WorkPlace, STATE) VALUES ('{0}', '{1}')";

                string stateFormat = string.Format(insertState, lastID, "0");

                sqlConnection.Open();

                SqlCommand stateCommand = new SqlCommand(stateFormat, sqlConnection);

                stateCommand.ExecuteNonQuery();

                sqlConnection.Close();

                string insertMoney = "INSERT INTO dbo.workPlace_Receips (Id_WorkPlace, salary_Hour) VALUES ('{0}', '{1}')";

                string moneyFormat = string.Format(insertMoney, lastID, money);

                sqlConnection.Open();

                SqlCommand moneyCommand = new SqlCommand(moneyFormat, sqlConnection);

                moneyCommand.ExecuteNonQuery();

                sqlConnection.Close();

                sqlConnection.Open();

                string clientsFormat = string.Format(addWorkPlaceString, lastID);

                SqlCommand clientsCommand = new SqlCommand(clientsFormat, sqlConnection);

                clientsCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }

        private void ChangeComputerButton_Click(object sender, EventArgs e)
        {
            string updateComputerString = "UPDATE dbo.PC_O SET Id_Peref = '{0}', Id_PC = '{1}', Id_PS = '{2}' WHERE Id_WorkPlace = '{3}'";
            string SearchIDPerefString = "SELECT * FROM dbo.Peref WHERE Peref_data = N'{0}'";
            string SearchIDPCString = "SELECT * FROM dbo.State_of_PC WHERE PC_data = N'{0}'";
            string SearchIDPSString = "SELECT * FROM dbo.state_of_PS WHERE PS = N'{0}'";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            MessageBox.Show("Введите ID компьютера");

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string computerID = add_Change_Form.Data();

                sqlConnection.Open();

                string searchString = string.Format(SearchIDPerefString, PerefComboBox.Text);

                SqlCommand searchIDPerefCommand = new SqlCommand(searchString, sqlConnection);

                var data = searchIDPerefCommand.ExecuteReader();
                data.Read();
                IDataRecord record = data;

                string Id_Peref = string.Format("{0}", record.GetValue(0).ToString());

                sqlConnection.Close();

                sqlConnection.Open();

                searchString = string.Format(SearchIDPCString, PC_ComboBox.Text);

                SqlCommand searchIDPCCommand = new SqlCommand(searchString, sqlConnection);

                data = searchIDPCCommand.ExecuteReader();
                data.Read();
                record = data;

                string Id_PC = string.Format("{0}", record.GetValue(0).ToString());

                sqlConnection.Close();

                sqlConnection.Open();

                searchString = string.Format(SearchIDPSString, PS_ComboBox.Text);

                SqlCommand searchIDPSCommand = new SqlCommand(searchString, sqlConnection);

                data = searchIDPSCommand.ExecuteReader();
                data.Read();
                record = data;

                string Id_PS = string.Format("{0}", record.GetValue(0).ToString());

                sqlConnection.Close();

                sqlConnection.Open();

                string updateFormat = string.Format(updateComputerString, Id_Peref, Id_PC, Id_PS, computerID);

                SqlCommand updateCommand = new SqlCommand(updateFormat, sqlConnection);

                updateCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Введите стоимость работы за час (пустота для неизменения)");

                if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
                {
                    if (add_Change_Form.Data() == "") return;
                    else
                    {
                        string money = add_Change_Form.Data();

                        string updateMoney = "UPDATE dbo.workPlace_Receips SET salary_Hour='{0}' WHERE Id_WorkPlace = '{1}'";

                        string updateMoneyFormat = string.Format(updateMoney, money, computerID);

                        sqlConnection.Open();

                        SqlCommand updateMoneyCommand = new SqlCommand(updateMoneyFormat, sqlConnection);

                        updateMoneyCommand.ExecuteNonQuery();

                        sqlConnection.Close();
                    }
                }
            }
        }
    }
}