using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoIrrf : Form
    {
        public frmDescontoIrrf()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu sálario!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                double resultado = IRRF.Calcula(salario);
                const double salarioLimite1 = 1903.99;

                if (salario < salarioLimite1)
                {
                    MessageBox.Show("Não é necessário entregar a declaração", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                }

                lblResultado.Text = resultado.ToString("F2");
                lblResultado.Visible = true;
                panelaResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

    }
}
