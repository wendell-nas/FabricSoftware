using iRh.Windows.Core;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace iRh.Windows.Simulação_Completa
{
    public partial class SimulacaoCompleta : Form
    {
        public SimulacaoCompleta()
        {
            InitializeComponent();
            this.Size = new Size(727, 258);
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
                
                
                if (sim.Checked)
                {                                     
                    var valorPassagem = double.Parse(txtPassagem.Text);
                    var quantidadeVales = double.Parse(txtVales.Text);
                    var valeTrasporte = ValeTransporte.Calcula(salario, valorPassagem, quantidadeVales);
                    lblResultadoValeTransporte.Text = "VALE TRANSPORTE: - " + valeTrasporte.ToString("F2");
                    var salarioLiquido = salario - inss - irrf - valeTrasporte;
                    lblResultado.Text = "SÁLARIO LÍQUIDO: " + salarioLiquido.ToString("F2");
                }

                if (simp.Checked)
                {
                    var perigo = periculosidade.Calcula(salario, horasTrabalhadas);
                    lblResultadoPericulosidade.Text = "PERICULOSIDADE: " + perigo.ToString("F2");
                }
                            
            }
            catch (Exception)
            {
                MessageBox.Show("Insira as informações necessárias", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
                throw;
            }
          
        }

        private void sim_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("O programa realizará os calcúlos!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nao.Visible = false;
        }

        private void nao_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Haverá nenhum calcúlo relacionado ao Vale transporte", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sim.Visible = false;
        }

        private void simp_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("O programa realizará os calcúlos!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            naop.Visible = false;
        }

        private void naop_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Haverá nenhum calcúlo relacionado ao Adicional Noturno", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            simp.Visible = false;
            txtPassagem.Enabled = true;
            txtVales.Enabled = true;
        }
    }
}
