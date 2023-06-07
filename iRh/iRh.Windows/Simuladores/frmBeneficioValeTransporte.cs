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
                double descontoVt = ValeTransporte.Calcula(salario, valorPassagem, quantidadeVale);
                lblResultado.Text = descontoVt.ToString();
                lblResultado.Visible = true;
                panel1.Visible = true;

                return;
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
                panelValores.Visible = true;
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

        private void checkBoxNaoGostaria_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNaoGostaria.Checked)
            {
                MessageBox.Show("Obrigado(a) por utilizar nosso programa, volte sempre!", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void checkBoxSimGostaria_CheckedChanged(object sender, EventArgs e)
        {

            if(checkBoxSimGostaria.Checked)
            {
                var valorDescontado = double.Parse(lblResultado.Text);
                var quantidadeTrabalhada = 20;
                var quantidaeVales = double.Parse(txtQuantidadeVales.Text);
                var valorPassagem = double.Parse(txtValorPassagem.Text);
                var gastoMensal = quantidaeVales * valorPassagem * quantidadeTrabalhada;
                
                if (gastoMensal > valorDescontado)
                {
                    MessageBox.Show("Vale a pena utilizar o vale transporte", "Use com moderação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não vale a pena utilizar o vale transporte", "Que pena :(", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                
            }
         
        }

      
    }
}
