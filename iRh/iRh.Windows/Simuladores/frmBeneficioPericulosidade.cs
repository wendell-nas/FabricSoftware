﻿using System.Windows.Forms;
using iRh.Windows.Core;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioPericulosidade : Form
    {
        public frmBeneficioPericulosidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
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
                var horaTrabalhadas = double.Parse(txtHoraTrabalhada.Text);
                double resultado = periculosidade.Calcula(salario, horaTrabalhadas);
                lblResultado.Text = resultado.ToString("F2");
                lblResultado.Visible = true;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Informe seu sálario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                throw;
            }
        }

    }
}
