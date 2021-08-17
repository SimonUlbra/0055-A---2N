using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            tbLista.Text = tbLista.Text + "  " + tbNome.Text;
            tbNome.Clear();
            tbNome.Focus();

        }

        private void btCopiar_Click(object sender, EventArgs e)
        {
            lbSaida.Text = tbLista.Text;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbLista.Clear();
            tbNome.Focus();
        }
    }
}
