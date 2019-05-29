using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUTO
{
    public partial class frmSetor : Form
    {
        public frmSetor()
        {
            InitializeComponent();
        }

        private void FrmSetor_Load(object sender, EventArgs e)
        {

        }

        private void BtnsSalvar_Click(object sender, EventArgs e)
        {
            int codigo;
            string descricao;

            codigo = Convert.ToInt32(txtsCodigo.Text);
            descricao = txtsDescricao.Text;

            SalvarCargo(codigo, descricao);
        }

        private void SalvarCargo(int codigo, string descricao)
        {
            StreamWriter setores;
            string caminho = "C:\\sistema1\\SETOR.txt";          
            setores = File.AppendText(caminho);
            setores.WriteLine();
            setores.WriteLine("Código: " + codigo);
            setores.WriteLine("Descrição: " + descricao);
            setores.Close();
            MessageBox.Show("Setor salvo com SUCESSO!!");
        }

        private void BtnsLimpar_Click(object sender, EventArgs e)
        {
            txtsCodigo.Clear();
            txtsDescricao.Clear();
        }
    }
}
