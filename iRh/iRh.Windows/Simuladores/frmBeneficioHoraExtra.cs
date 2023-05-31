using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioHoraExtra : Form
    {
        public frmBeneficioHoraExtra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
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
                var cargaHoraria = double.Parse(txtCargaHoraria.Text);
                var horaExtraTotal = HoraExtra.Calcula(salario, cargaHoraria);

                lblResultado.Text = "R$ " + horaExtraTotal.ToString("F2");
                panelResultado.Visible = true;
  
            }
            catch (System.Exception)
            {

                MessageBox.Show("Informe seu sálario base", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            }
        }
    }
}
