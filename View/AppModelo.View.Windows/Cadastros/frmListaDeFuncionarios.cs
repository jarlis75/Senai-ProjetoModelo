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
    public partial class frmListaDeFuncionarios : Form
    {

        private FuncionarioController _funcionarioController = new FuncionarioController();

        public frmListaDeFuncionarios()
        {
            InitializeComponent();

            var listaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            dgvListarFuncionarios.DataSource = listaFuncionarios;
        }
    }
}
