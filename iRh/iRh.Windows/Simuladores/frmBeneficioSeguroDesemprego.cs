using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Simuladores
{
    public partial class frmBeneficioSeguroDesemprego : Form
    {
        public frmBeneficioSeguroDesemprego()
        {
            InitializeComponent();
        }

        private void btnVerificarAgora_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMesesTrabalhados.Text))
            {
                MessageBox.Show("Insira as informações!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMesesTrabalhados.Focus();
                txtVezesQueJaSolicitou.Focus();
                return;
            }
            try
            {
                var mesesTrabalhados = double.Parse(txtMesesTrabalhados.Text);
                var vezesSolicitado = double.Parse(txtVezesQueJaSolicitou.Text);

                if (vezesSolicitado == 0)
                {
                    if (mesesTrabalhados < 12)
                    {
                        MessageBox.Show("NÃO ESTÁ APTO A RECEBER O BENEFÍCIO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 8 && mesesTrabalhados < 12)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 3 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 11 && mesesTrabalhados < 24)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 3 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 23)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 5 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (vezesSolicitado == 1)
                {
                    if (mesesTrabalhados < 9)
                    {
                        MessageBox.Show("VOCÊ NÃO ESTÁ APTO A RECEBER O BENEFICIO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 8 && mesesTrabalhados < 12)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 3 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 11 && mesesTrabalhados < 24)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 3 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 23)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 5 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (vezesSolicitado >= 2)
                {
                    if (mesesTrabalhados < 6)
                    {
                        MessageBox.Show("NÃO! ESTÁ APTO A RECEBER O BENEFÍCIO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados < 12 && mesesTrabalhados > 5)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 3 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 11 && mesesTrabalhados < 24)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 4 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (mesesTrabalhados > 23)
                    {
                        MessageBox.Show("ESTÁ APTO A RECEBER 5 PARCELAS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Insira as informações!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
