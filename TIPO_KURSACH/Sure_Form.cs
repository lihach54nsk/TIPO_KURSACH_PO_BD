﻿using System;
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
    public partial class Sure_Form : Form
    {
        public Sure_Form()
        {
            InitializeComponent();
        }

        bool question = false;

        private void YesButtton_Click(object sender, EventArgs e)
        {
            question = true;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            question = false;
        }

        public bool Sure()
        {

            return question;
        }
    }
}