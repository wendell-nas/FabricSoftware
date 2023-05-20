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
            }
            catch (Exception)
            {
                MessageBox.Show("Informe seu sálario base", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
        }
    }
}
