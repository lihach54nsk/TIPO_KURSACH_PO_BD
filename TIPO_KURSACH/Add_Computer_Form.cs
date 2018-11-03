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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Геральт из Ривии\Documents\TIPO_KURSACH\TIPO_KURSACH\Database1.mdf;Integrated Security = True";

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

            SqlConnection sqlConnection = new SqlConnection(connectionString);
        }

        private void ChangePC_Button_Click(object sender, EventArgs e)
        {

        }

        private void ChangePS_Button_Click(object sender, EventArgs e)
        {

        }

        private void DeletePerefButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePC_Button_Click(object sender, EventArgs e)
        {

        }

        private void DeletePS_Button_Click(object sender, EventArgs e)
        {

        }
    }
}