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
        }

        private void AddPerefButton_Click(object sender, EventArgs e)
        {
            string queryString = "INSERT INTO dbo.Peref (Peref_Data) VALUES (N'{0}')";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            Add_Change_Form add_Change_Form = new Add_Change_Form();

            sqlConnection.Open();

            if (add_Change_Form.ShowDialog(this) == DialogResult.OK)
            {
                string addFormat = string.Format(queryString, add_Change_Form.Data());
                add_Change_Form.Dispose();

                SqlCommand command = new SqlCommand(addFormat, sqlConnection);

                command.ExecuteNonQuery();
            }
            else add_Change_Form.Dispose();

            sqlConnection.Close();
        }

        private void AddPC_Button_Click(object sender, EventArgs e)
        {

        }

        private void AddPS_Button_Click(object sender, EventArgs e)
        {

        }

        private void ChangePerefButton_Click(object sender, EventArgs e)
        {

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