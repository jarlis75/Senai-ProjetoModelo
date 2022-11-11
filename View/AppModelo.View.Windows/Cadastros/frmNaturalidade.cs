using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppModelo.View.Windows.Cadastros
{
    
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();

            var listaDeNacionalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);
            if (temNumero)
            {
                errorProvider.SetError(txtDescricao, "Naturalidade não tem Número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkAtivo.Checked);

            MessageBox.Show("Naturalidade cadastrada com Sucesso");
        }

              
        private void txtDescricao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
           //primeira regra nome < que 30 letras
            if (txtDescricao.Text.Length < 30)
            {
                errorProvider.SetError(txtDescricao, "Digite sua Naturalidade");
                return;
            }

            //verifica se digitou algum numero
            foreach (var letra in txtDescricao.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtDescricao, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();

        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (var letra in txtDescricao.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtDescricao, "Campo não pode conter Numerais e nem caracteres especiais!");
                    return;
                }
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidades.DataSource = listaDeNaturalidades;

            MessageBox.Show("Naturalidades Atualizadas com Sucesso");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var converter = int.Parse(txtId.Text);

            var removeu = _naturalidadeController.ExcluirNaturalidade(converter);
            if (removeu)
            {
                MessageBox.Show("Naturalidade excluída com sucesso");
                txtId.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Verifique se digitou o nome conforme descrito na lista abaixo");

            }
        }
    }
}
