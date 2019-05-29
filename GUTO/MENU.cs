using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUTO
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void BtnAjuda_Click(object sender, EventArgs e)
        {
            frmAjuda AJUDA = new frmAjuda();
            AJUDA.ShowDialog();
        }

        private void FMENU_Load(object sender, EventArgs e)
        {

        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos PRODUTOS = new frmProdutos();
            PRODUTOS.ShowDialog();
        }

        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionarios FUNCIONARIO = new frmFuncionarios();
            FUNCIONARIO.ShowDialog();

        }

        private void BtnCargo_Click(object sender, EventArgs e)
        {
            frmCargos CARGOS = new frmCargos();
            CARGOS.ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            frmClientes CLIENTES = new frmClientes();
            CLIENTES.ShowDialog();
        }

        private void BtnSetor_Click(object sender, EventArgs e)
        {
            frmSetor SETOR = new frmSetor();
            SETOR.ShowDialog();
        }
    }
}
