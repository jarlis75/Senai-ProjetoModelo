using AppModelo.Controller.Cadastros;
using AppModelo.View.Windows.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();

            
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }

        private void nacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }

        public void dgvListarFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

      
        private void txtListar_Click(object sender, EventArgs e)
        {
            var form = new frmListaDeFuncionarios();
            form.Show();
        }
    }
}
