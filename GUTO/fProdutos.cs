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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void FProdutos_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtpCodigo.Clear();
            txtpNome.Clear();
            txtpLucro.Clear();
            txtpVenda.Clear();
            txtpCusto.Clear();
            txtpBarras.Clear();
            cbxpCategoria.SelectedIndex = -1;
            cbxpMarca.SelectedIndex = -1;
            cbxpMedida.SelectedIndex = -1;
            cbxpOrigem.SelectedIndex = -1;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome, codigo, barras, custo, venda, lucroporcent, unidamedida, origem, marca, categoria;

            nome = txtpNome.Text;
            codigo = txtpCodigo.Text;
            barras = txtpBarras.Text;
            custo = txtpCusto.Text;
            venda = txtpVenda.Text;
            lucroporcent = txtpLucro.Text;
            unidamedida = cbxpMedida.Items[cbxpMedida.SelectedIndex].ToString();
            origem = cbxpOrigem.Items[cbxpOrigem.SelectedIndex].ToString();
            marca = cbxpMarca.Items[cbxpMarca.SelectedIndex].ToString();
            categoria = cbxpCategoria.Items[cbxpCategoria.SelectedIndex].ToString();

            SalvarProdutos(codigo, nome, barras, custo, venda, lucroporcent, unidamedida, origem, marca, categoria);
        }

        private void SalvarProdutos(string codigo, string nome, string barras, string custo, string venda, string lucroporcent, string unidamedida, string origem, string marca, string categoria)
        {
            StreamWriter produtos;
            string caminho = "C:\\sistema1\\PRODUTOS.txt";

            produtos = File.AppendText(caminho);
            produtos.WriteLine("Código: " + codigo);
            produtos.WriteLine("Nome: " + nome);
            produtos.WriteLine("Código de barras: " + barras);
            produtos.WriteLine("Preço de custo: " + custo);
            produtos.WriteLine("Preço de venda: " + venda);
            produtos.WriteLine("Lucro%: " + lucroporcent);
            produtos.WriteLine("Unidade de Medida: " + unidamedida);
            produtos.WriteLine("Origem do Produto: " + origem);
            produtos.WriteLine("Marca: " + marca);
            produtos.WriteLine("Categoria: " + categoria);
            produtos.Close();
            MessageBox.Show("Produto salvo com SUCESSO!!");
        }
    }
}
