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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            rbnFisica.Checked = false;
            rbnJuridica.Checked = false;
            cbxAtivo.Checked = false;
            txtNome.Clear();
            mtxtNascimento.Clear();
            txtCnpj.Clear();
            txtRG.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbxEstado.SelectedIndex = -1;
            txtCep.Clear();
            mtxtTelefone.Clear();
            mtxtCelular.Clear();
            txtContato.Clear();
            txtEmail.Clear();
            txtSite.Clear();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string codigo, nome, pessoa, ativo, nascimento, cpf, rg, endereco, bairro, cidade, estado, cep, telefone, celular, contato, email, site;

            codigo = txtCodigo.Text;
            nome = txtNome.Text;
            nascimento = mtxtNascimento.Text;
            cpf = txtCnpj.Text;
            rg = txtRG.Text;
            endereco = txtEndereco.Text;
            bairro = txtBairro.Text;
            cidade = txtCidade.Text;
            estado = cbxEstado.Items[cbxEstado.SelectedIndex].ToString();
            cep = txtCep.Text;
            telefone = mtxtTelefone.Text;
            celular = mtxtCelular.Text;
            contato = txtContato.Text;
            email = txtEmail.Text;
            site = txtSite.Text;

            if (rbnFisica.Checked == true)
            {
                pessoa = "FÍSICA";
            }
            else
            {
                pessoa = "";
            }

            if (rbnJuridica.Checked == true)
            {
                pessoa = "JURÍDICA";
            }
            else
            {
                pessoa = "";
            }

            if (cbxAtivo.Checked == true)
            {
                ativo = "ATIVO";
            }
            else
            {
                ativo = "Não é ATIVO";
            }

            SalvarClientes(codigo, nome, pessoa, ativo, nascimento, cpf, rg, endereco, bairro, cidade, estado, cep, telefone, celular, contato, email, site);

        }

        private void SalvarClientes(string codigo, string nome, string pessoa, string ativo, string nascimento, string cpf, string rg, string endereco, string bairro, string cidade, string estado, string cep, string telefone, string celular, string contato, string email, string site)
        {
            StreamWriter cliente;
            string caminho = "C:\\sistema1\\CLIENTE.txt";

            cliente = File.AppendText(caminho);
            cliente.WriteLine("Código: " + codigo);
            cliente.WriteLine("Nome: " + nome);
            cliente.WriteLine("Pessoa: " + pessoa);
            cliente.WriteLine("Ativo: " + ativo);
            cliente.WriteLine("Nascimento: " + nascimento);
            cliente.WriteLine("CNPJ/CPF: " + cpf);
            cliente.WriteLine("Inscrição Estadual/RG: " + rg);
            cliente.WriteLine("Endereço: " + endereco);
            cliente.WriteLine("Bairro: " + bairro);
            cliente.WriteLine("Cidade: " + cidade);
            cliente.WriteLine("Estado: " + estado);
            cliente.WriteLine("CEP: " + cep);
            cliente.WriteLine("Telefone: " + telefone);
            cliente.WriteLine("Celular: " + celular);
            cliente.WriteLine("Contato: " + contato);
            cliente.WriteLine("E-mail: " + email);
            cliente.WriteLine("Site: " + site);

            cliente.Close();
            MessageBox.Show("Cliente salvo com SUCESSO!!");
        }
    }
}
