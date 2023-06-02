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
    public partial class frmBeneficioPis : Form
    {
        public frmBeneficioPis()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTempoDeEmpresa.Text))
            {
                MessageBox.Show("Informe o valor pedido", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTempoDeEmpresa.Focus();
                txtTempoDePis.Focus();
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var tempoDeEmpresa = double.Parse(txtTempoDeEmpresa.Text);
                var tempoDePis = double.Parse(txtTempoDePis.Text);
                double resultado = Pis.Calcula(tempoDeEmpresa, tempoDePis, salario);

                if(tempoDePis < 5)
                {
                    MessageBox.Show("Você não tem direito de usufruir do programa PIS", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Você tem direito ao programa PIS, vamos fazer o cálculo do seu PIS", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblResultado.Text = "Já que você tem direito ao" + Environment.NewLine  + "o PIS, você irá receber:" + resultado.ToString();
                    panelResultado.Visible = true;
                }




            }
            catch (Exception)
            {
                MessageBox.Show("Informe o valor pedido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                throw;
            }

        }
    }
}
