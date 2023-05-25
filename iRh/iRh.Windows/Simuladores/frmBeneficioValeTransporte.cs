using System;
using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioValeTransporte : Form
    {
        public frmBeneficioValeTransporte()
        {
            InitializeComponent();
        }

        private void btnCalcularValeTransporte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu sálario base", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var quantidadeVale = double.Parse(txtQuantidadeVales.Text); ;
                var valorPassagem = double.Parse(txtValorPassagem.Text);
                double descontoVt = ValeTransporte.Calcula(salario);

                lblResultado.Text = "R$" + descontoVt.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkBoxUtilizoTransporte_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxUtilizoTransporte.Checked)
            {
                MessageBox.Show("Você tem direito ao vale transporte" + Environment.NewLine + Environment.NewLine + "CLIQUE 'OK' PARA CONTINUAR");
                checkBoxNaoUtilizoTransporte.Visible = false;
            }
        }

        private void checkBoxNaoUtilizoTransporte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNaoUtilizoTransporte.Checked)
            {
                MessageBox.Show("Você não tem direito ao vale transporte!", "Atençaõ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
