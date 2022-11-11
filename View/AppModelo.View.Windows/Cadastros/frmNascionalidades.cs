using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNascionalidades : Form
    {
        private NascionalidadeController _nascionalidadeController = new NascionalidadeController();
        public frmNascionalidades()
        {
            InitializeComponent();
            var listaDeNacionalidades = _nascionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var salvou = _nascionalidadeController.Cadastrar(txtDescricao.Text);

            if (salvou) 
            {
                MessageBox.Show("Nacionalidade Incluida com Sucesso");
                txtDescricao.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");
            }
        }
    }
}
