using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
            if (temNumero)
            {
                errorProvider.SetError(txtDescricao, "Nacionalidade não tem Número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NacionalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula);

            MessageBox.Show("Naturalidade cadastrada com Sucesso");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;

            MessageBox.Show("Nacionalidades Atualizadas com Sucesso");
            
            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var converter = int.Parse(txtId.Text);

            var removeu = _nacionalidadeController.ExcluirNacionalidade (converter);
            if (removeu)
            {
                MessageBox.Show("Nacionalidade excluída com sucesso");
                txtId.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Verifique se digitou o nome conforme descrito na lista abaixo");

            }
        }
    }
}
