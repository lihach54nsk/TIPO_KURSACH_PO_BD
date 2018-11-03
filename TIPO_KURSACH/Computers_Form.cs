using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIPO_KURSACH
{
    public partial class Computers_Form : Form
    {
        public Computers_Form()
        {
            InitializeComponent();
        }

        private void AddComputerButton_Click(object sender, EventArgs e)
        {
            Add_Computer_Form add_Computer_Form = new Add_Computer_Form();

            add_Computer_Form.Show();
        }

        private void ChangeDataComputerButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteComputerButton_Click(object sender, EventArgs e)
        {

        }
    }
}