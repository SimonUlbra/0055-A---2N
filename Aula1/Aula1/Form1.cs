﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   

        private void btOK_Click_Click(object sender, EventArgs e)
        {
            tbLista = tbLista + "; " + tbNome.Text;
        }
    }
}
