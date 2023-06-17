using iRh.Windows.Core;
using System;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioAdicionalNoturno : Form
    {
        public frmBeneficioAdicionalNoturno()
        {
            InitializeComponent();
        }

        private void btnCalcularAdicional_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoraNoturna.Text))
            {
                MessageBox.Show("Informe o salario e as horas", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoraNoturna.Focus();
                return;
            }
            try
            {
                var horasNoturna = double.Parse(txtHoraNoturna.Text);
                double horasMensal = 220;
                var salario = double.Parse(txtSalario.Text);
                double salarioComAdicional = AdicionalNoturno.Calcula(horasMensal, horasNoturna, salario);

                lblResultado.Text = salarioComAdicional.ToString("F2");
                lblResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe o salario e as horas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
