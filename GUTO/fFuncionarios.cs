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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void LblfContato_Click(object sender, EventArgs e)
        {

        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void BtnfSalvar_Click(object sender, EventArgs e)
        {
            string codigo, registro, nome, ativo, nascimento, cpf, rg, salario, admissao, demissao, extra, cargo, setor, endereco, bairro, cidade, estado, cep, telefone, celular, contato, email, site;

            codigo = txtfCodigo.Text;
            registro = txtfRegistro.Text;
            nome = txtfNome.Text;
            nascimento = mtxfNascimento.Text;
            cpf = txtfCpf.Text;
            rg = txtfRg.Text;
            salario = txtfSalario.Text;
            admissao = cbxfAdmissao.Text;
            demissao = cbxfDemissao.Text;
            extra = txtfExtra.Text;
            cargo = cbxfCargo.Items[cbxfCargo.SelectedIndex].ToString();
            setor = cbxfSetor.Items[cbxfSetor.SelectedIndex].ToString();
            endereco = txtfEndereco.Text;
            bairro = txtfBairro.Text;
            cidade = txtfCidade.Text;
            estado = cbxfEstado.Items[cbxfEstado.SelectedIndex].ToString();
            cep = txtfCep.Text;
            telefone = mtxfTelefone.Text;
            celular = mtxfCelular.Text;
            contato = txtfContato.Text;
            email = txtfEmail.Text;
            site = txtfSite.Text;

            if (ckxfAtivo.Checked == true)
            {
                ativo = "ATIVO";
            }
            else
            {
                ativo = "Não é ATIVO";
            }

            SalvarFuncionario(codigo, registro, nome, nascimento, admissao, demissao, cpf, rg, salario, extra, cargo, setor, endereco, bairro, cidade, email, telefone, celular, contato, ativo, site, estado, cep);

        }

        private void SalvarFuncionario(string codigo, string registro, string nome, string nascimento, string admissao, string demissao, string cpf, string rg, string salario, string extra, string cargo, string setor, string endereco, string bairro, string cidade, string email, string telefone, string celular, string contato, string ativo, string site, string estado, string cep)
        {
            StreamWriter Funcionarios;
            string caminho = "C:\\sistema1\\FUNCIONARIOS.txt";

            Funcionarios = File.AppendText(caminho);
            Funcionarios.WriteLine("Código: " + codigo);
            Funcionarios.WriteLine("Número de registro: " + registro);
            Funcionarios.WriteLine("Nome: " + nome);
            Funcionarios.WriteLine("Nascimento: " + nascimento);
            Funcionarios.WriteLine("CPF: " + cpf);
            Funcionarios.WriteLine("RG: " + rg);
            Funcionarios.WriteLine("Salário: " + salario);
            Funcionarios.WriteLine("Extra: " + extra);
            Funcionarios.WriteLine("Admissão: " + admissao);
            Funcionarios.WriteLine("Demissão: " + demissao);
            Funcionarios.WriteLine("Cargo: " + cargo);
            Funcionarios.WriteLine("Setor: " + setor);
            Funcionarios.WriteLine("Endereço: " + endereco);
            Funcionarios.WriteLine("Bairro: " + bairro);
            Funcionarios.WriteLine("Cidade: " + cidade);
            Funcionarios.WriteLine("Estado: " + estado);
            Funcionarios.WriteLine("CEP: " + cep);
            Funcionarios.WriteLine("Telefone: " + telefone);
            Funcionarios.WriteLine("Celular: " + celular);
            Funcionarios.WriteLine("E-mail: " + email);
            Funcionarios.WriteLine("Site: " + site);
            Funcionarios.WriteLine("Contato: " + contato);
            Funcionarios.WriteLine("Ativo: " + ativo);
            Funcionarios.Close();
            MessageBox.Show("Funcionarios salvo com SUCESSO!!");

        }

        private void BtnfLimpar_Click(object sender, EventArgs e)
        {
            txtfNome.Clear();
            txtfExtra.Clear();
            txtfEndereco.Clear();
            txtfEmail.Clear();
            txtfCpf.Clear();
            txtfContato.Clear();
            txtfCodigo.Clear();
            txtfCidade.Clear();
            txtfCep.Clear();
            txtfBairro.Clear();
            txtfRegistro.Clear();
            txtfRg.Clear();
            txtfSalario.Clear();
            txtfSite.Clear();            
            mtxfCelular.Clear();      
            mtxfNascimento.Clear();
            mtxfTelefone.Clear();
            ckxfAtivo.Checked = false;
            cbxfCargo.SelectedIndex = -1;
            cbxfEstado.SelectedIndex = -1;
            cbxfSetor.SelectedIndex = -1;
            cbxfAdmissao.SelectedIndex = -1;
            cbxfDemissao.SelectedIndex = -1;
        }
    }
}
