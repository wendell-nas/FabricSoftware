using iRh.Windows.Core;
using System.Linq;
using System.Windows.Forms;

namespace iRh.Windows.Cadastros
{

    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }
        private void frmFuncionario_Load(object sender, System.EventArgs e)
        {
            CarregarEstados();
            CarregarDocumentos();
        }
        private void CarregarEstados()
        {
            var estado = new Estados();
            var listaEstados = estado.ObterTodosEstados();
            var estadosAz = listaEstados.OrderBy(x => x.Sigla).ToList();

            cmbEstados.Items.Clear();
            cmbEstados.DataSource = estadosAz;
            cmbEstados.DisplayMember = "Nome";
            cmbEstados.ValueMember = "Sigla";
        }
        private void CarregarDocumentos()
        {
            var documentos = new Documentos();
            var listaDocumentos = documentos.ObterDocumentos();
            var documentosAz = listaDocumentos.OrderBy(x => x.Descricao).ToList();

            cmbDocumentos.Items.Clear();
            cmbDocumentos.DataSource = documentosAz;
            cmbDocumentos.DisplayMember = "Descricao";
            cmbDocumentos.ValueMember = "Id";
        }

        private void btnPesquisar_Click(object sender, System.EventArgs e)
        {
            var cepDigitado = txtCep.Text;
            if(cepDigitado.Length < 9)
            {
                MessageBox.Show("Insira um cep válido!!", "ERRO", MessageBoxButtons.OK);
                txtCep.Focus();
                return;
            }
            var endereco = new Endereco();
            var enderecoCompleto = endereco.ObterPorCep(cepDigitado);

            if (string.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show("Insira um cep válido!!", "ERRO", MessageBoxButtons.OK);
                txtCep.Focus();
                return;                           
            }
            try
            {
                if(endereco.Erro)
                {
                    MessageBox.Show("Insira um cep válido!!", "ERRO", MessageBoxButtons.OK);
                    txtBairro.Enabled = true;
                    txtLogradouro.Enabled = true;
                    txtNumero.Enabled = true;
                    txtCidade.Enabled = true;
                    txtDdd.Enabled = true;
                    return;
                }

                txtLogradouro.Text = enderecoCompleto.Logradouro;
                txtBairro.Text = enderecoCompleto.Bairro;
                txtCidade.Text = enderecoCompleto.Localidade;
                txtDdd.Text = enderecoCompleto.Ddd;
                cmbEstados.SelectedValue = enderecoCompleto.Uf;

                //Desabilitando as textBox
                txtBairro.Enabled = false;
                txtLogradouro.Enabled = false;
                txtNumero.Enabled = false;
                txtCidade.Enabled = false;
                txtDdd.Enabled = false;

            }
            catch (System.Exception)
            {
                MessageBox.Show("Insira um cep válido!!", "ERRO", MessageBoxButtons.OK);
                txtCep.Focus();
                
            }
                            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=" + txtDdd + txtTelefone + "&text=Olá%2C%20como%20posso%20te%20ajuda%3F");
        }      
    }
}
