using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class PerguntasValeTransporte : Form
    {
        public PerguntasValeTransporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var valorPassagem = txtPassagem.Text;
            var quantidadeVales = txtVales.Text;
        }
    }
}
