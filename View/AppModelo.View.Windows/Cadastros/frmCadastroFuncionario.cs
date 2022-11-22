using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        private FuncionarioController _funcionarioController = new FuncionarioController();

        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "Id";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNaturalidade.ValueMember = "Id";

        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        


        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //primeira regra nome < que 6 letras
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome,"Digite seu nome completo");
                return;
            }

            //verifica se digitou algum numero
            foreach(var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider
                        .SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();

           
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }
       



        // Gravar Funcionarios no Banco de dados.
        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        {
            var funController = new FuncionarioController();
            var dataNasc = Convert.ToDateTime(txtDataNascimento.Text);
            int numero = int.Parse(txtEnderecoNumero.Text);
            var naturalidade = Convert.ToInt32(cmbNaturalidade.SelectedValue);
            var nacionalidade = Convert.ToInt32(cmbNacionalidade.SelectedValue);

            //Recebo os dados do metodo obter para o endereço
            var salvou = funController.SalvarCadastro(txtNome.Text,dataNasc, rbMasculino.Checked,txtCpf.Text, nacionalidade, naturalidade, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text,numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);
            MessageBox.Show("Salvo com Sucesso!");
           LimparForm();
        }

        public void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterNacionalidade = cmbNacionalidade.SelectedIndex;
            string Index = cmbNacionalidade.Text;
            
        }

        public void cmbNaturalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterNaturalidade = cmbNaturalidade.SelectedIndex;
            string Index = cmbNaturalidade.Text;
            
        }

        private void LimparForm()
        {
            foreach (Control controle in this.Controls)
            {
                switch (controle)
                {
                    case TextBox:
                        ((TextBox)controle).Clear();
                        break;

                    case MaskedTextBox:
                        ((MaskedTextBox)controle).Text = "";
                        break;

                    case ComboBox:
                        ((ComboBox)controle).SelectedIndex = 0;
                        break;
                }
            }

        }
    }
}

