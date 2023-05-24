using iRh.Windows.Core;
using System;
using System.Windows.Forms;


namespace iRh.Windows.Simuladores
{
    public partial class frmDescontoInss : Form
    {
        public frmDescontoInss()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSalarioBase.Text))
            {
                MessageBox.Show("Informe seu sálario base", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalarioBase.Focus();
                return;
            }
            try
            {
                var salario = double.Parse(txtSalarioBase.Text);
                var descontoInss = Inss.Calcula(salario);

                lblResultado.Text = "R$ " + descontoInss.ToString("F2");
                panelResultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
