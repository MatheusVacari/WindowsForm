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
    public partial class frmCargos : Form
    {
        public frmCargos()
        {
            InitializeComponent();
        }

        private void BtncSalvar_Click(object sender, EventArgs e)
        {
            int codigo;
            string descricao;

            codigo = Convert.ToInt32(txtcCodigo.Text);
            descricao = txtcDescricao.Text;

            SalvarCargo(codigo, descricao);
        }

        private void SalvarCargo(int codigo, string descricao)
        {
            StreamWriter cargos;
            string caminho = "C:\\sistema1\\CARGOS.txt";

            cargos = File.AppendText(caminho);
            cargos.WriteLine("CÓDIGO: " + codigo);
            cargos.WriteLine("DESCRIÇÃO: " + descricao);
            cargos.Close();
            MessageBox.Show("Cargo salvo com SUCESSO!!");
        }

        private void BtncLimpar_Click(object sender, EventArgs e)
        {
            txtcCodigo.Clear();
            txtcDescricao.Clear();
        }
    }
}
