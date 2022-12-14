using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var Email = txtEmail.Text;
            var emailEhValido = Validadores.EmailEValido(Email);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Email Inválido");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha não encontrado");

            }

            
        }

        private void txtEsqueciSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
            
        }

        public void txtEmail_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            var form = new frmLogin();
            Close();
        }
    }
}
