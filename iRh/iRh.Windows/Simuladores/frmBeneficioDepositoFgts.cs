using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioDepositoFgts : Form
    {
        public frmBeneficioDepositoFgts()
        {
            InitializeComponent();
        }

        private void btnCalcularFgts_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Informe seu sálario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalario.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalario.Text);
                var fgtsMensal = Fgts.CalculaFgts(salario);

                lblResultado.Text = "R$ " + fgtsMensal.ToString("F2");
                lblResultado.Visible = true;
            }
            catch (System.Exception)
            {

                MessageBox.Show("Informe seu sálario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
