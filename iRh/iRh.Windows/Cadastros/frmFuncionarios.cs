using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            rbRemFilhosNao.Checked = true;
            panelExibeDadosFilhos.Visible = false;
        }

        private void rbRemFilhosSim_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = true;
        }

        private void rbRemFilhosNao_CheckedChanged(object sender, EventArgs e)
        {
            panelExibeDadosFilhos.Visible = false;
        }

        private void txtFilhoDataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var dataNascimento = DateTime.Parse(txtFilhoDataNascimento.Text);
                    var anoAtual = DateTime.Now.Year;

                    lblIdade.Text = (anoAtual - dataNascimento.Year).ToString();
                    panelExibeDadosFilhos.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A data de nascimento parece estar errada, detalhamento: " + ex.Message);

                }
            }

        }
        private string Comprimentador(int opcaoSelecionada)
        {
            switch (opcaoSelecionada)
            {
                case 1: return "Prezado, Senhor: ";
                case 2: return "Prezada, Senhora: ";
                default:
                    return "Prezades, Senhore";
            }
        }
    }
}
