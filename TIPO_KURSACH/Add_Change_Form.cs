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
    public partial class Add_Change_Form : Form
    {
        public Add_Change_Form()
        {
            InitializeComponent();
        }

        public void EnterButton_Click(object sender, EventArgs e)
        { }

        public string Data() => EnterTextBox.Text;
    }
}