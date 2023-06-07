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
    public partial class frmBeneficioFerias : Form
    {
        public frmBeneficioFerias()
        {
            InitializeComponent();
        }

        private void btnCalcularFerias_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu sálario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                double descontoInss = Inss.Calcula(salario);
                double resultado = Ferias.Calcula(salario);
                lblResultado.Text = resultado.ToString("F2");
                lblResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
