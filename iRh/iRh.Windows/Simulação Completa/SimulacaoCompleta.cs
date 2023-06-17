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
using iRh.Windows.Simuladores;



namespace iRh.Windows.Simulação_Completa
{
    public partial class SimulacaoCompleta : Form
    {
        public SimulacaoCompleta()
        {
            InitializeComponent();
        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
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
                var horasTrabalhadas = double.Parse(txtHorasTrabalhadas.Text);
                var horaNoturna = double.Parse(txtHorasNoturna.Text);
                double horaMensal = 220; 
                var inss = Inss.Calcula(salario);
                var irrf = Irrf.Calcula(salario);
                var depositoFgts = Fgts.CalculaFgts(salario);
                var horaExtra = HoraExtra.Calcula(salario, horasTrabalhadas);
                var adicionalNoturno = AdicionalNoturno.Calcula(horaMensal, horaNoturna, salario);
                lblResultadoSalarioBase.Text = "SALARIO BASE: " + salario.ToString("F2");
                lblResultadoInss.Text = "INSS: -" + inss.ToString("F2");
                lblResultadoIrrf.Text = "IRRF: -" + irrf.ToString("F2");
                lblResultadoIrrf.Text = "IRRF: -" + irrf.ToString("F2");
                lblDepositoFgts.Text = "DEPÓSITO FGTS: " + depositoFgts.ToString("F2");
                lblResultadoHoraExtra.Text = "HORA EXTRA: " + horaExtra.ToString("F2");
                lblResultadoAdicionalNoturno.Text = "ADICIONAL NOTURNO: " + adicionalNoturno.ToString("F2");
                panelResultado.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Insira as informações necessárias", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
                throw;
            }

        }

 
  

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            panelInformacaoValeTransporte.Visible = false;
        }

        private void sim_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Responda as perguntas para prosseguirmos!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHorasTrabalhadas.Focus();
            panelInformacaoValeTransporte.Visible = true;
            var salario = double.Parse(txtSalario.Text);
            var valorPassagem = double.Parse(txtPassagem.Text);
            var quantidadeVales = double.Parse(txtVales.Text);
            if (sim.Checked)
            {

                var valeTrasporte = ValeTransporte.Calcula(salario, valorPassagem, quantidadeVales);
                lblResultadoValeTransporte.Text = "VALE TRANSPORTE: - " + valeTrasporte.ToString("F2");

            }
            return;
        }

        private void nao_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Haverá nenhum calcúlo relacionado ao Vale transporte", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHorasTrabalhadas.Focus();

            return;
        }

        private void simp_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("O programa realizará os calcúlos!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHorasTrabalhadas.Focus();

            return;
        }

        private void naop_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Haverá nenhum calcúlo relacionado ao Adicional de Periculosidade", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtHorasTrabalhadas.Focus();

            return;
        }
    }
}
