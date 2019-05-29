namespace GUTO
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbnFisica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.rbnJuridica = new System.Windows.Forms.RadioButton();
            this.gbxTrabalho = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CLIENTES";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 71);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 21);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 43);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 21);
            this.txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "CNPJ/CPF:";
            // 
            // rbnFisica
            // 
            this.rbnFisica.AutoSize = true;
            this.rbnFisica.Location = new System.Drawing.Point(101, 10);
            this.rbnFisica.Name = "rbnFisica";
            this.rbnFisica.Size = new System.Drawing.Size(58, 19);
            this.rbnFisica.TabIndex = 7;
            this.rbnFisica.TabStop = true;
            this.rbnFisica.Text = "Física\r\n";
            this.rbnFisica.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(232, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 24);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(6, 141);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(63, 15);
            this.t.TabIndex = 9;
            this.t.Text = "Endereço:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(72, 105);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(163, 21);
            this.txtCnpj.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(72, 141);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(142, 21);
            this.txtEndereco.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(72, 177);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(114, 21);
            this.txtCidade.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nascimento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "E-Mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 21);
            this.txtEmail.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Bairro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Inscrisão Estadual / RG:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Estado:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(399, 102);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(138, 21);
            this.txtRG.TabIndex = 23;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(399, 132);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(138, 21);
            this.txtBairro.TabIndex = 24;
            // 
            // mtxtTelefone
            // 
            this.mtxtTelefone.Location = new System.Drawing.Point(72, 214);
            this.mtxtTelefone.Mask = "(999) 000-0000";
            this.mtxtTelefone.Name = "mtxtTelefone";
            this.mtxtTelefone.Size = new System.Drawing.Size(142, 21);
            this.mtxtTelefone.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(455, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 29;
            this.label14.Text = "CEP:";
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Location = new System.Drawing.Point(444, 41);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(51, 19);
            this.cbxAtivo.TabIndex = 30;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(310, 198);
            this.mtxtCelular.Mask = "(999) 000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(116, 21);
            this.mtxtCelular.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(437, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Contato:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(259, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 33;
            this.label16.Text = "Celular:";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(493, 195);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(100, 21);
            this.txtContato.TabIndex = 35;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(493, 163);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(118, 21);
            this.txtCep.TabIndex = 36;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(259, 241);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(31, 15);
            this.lblSite.TabIndex = 37;
            this.lblSite.Text = "Site:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(296, 238);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(258, 21);
            this.txtSite.TabIndex = 38;
            // 
            // rbnJuridica
            // 
            this.rbnJuridica.AutoSize = true;
            this.rbnJuridica.Location = new System.Drawing.Point(14, 8);
            this.rbnJuridica.Name = "rbnJuridica";
            this.rbnJuridica.Size = new System.Drawing.Size(68, 19);
            this.rbnJuridica.TabIndex = 8;
            this.rbnJuridica.TabStop = true;
            this.rbnJuridica.Text = "Jurídica";
            this.rbnJuridica.UseVisualStyleBackColor = true;
            // 
            // gbxTrabalho
            // 
            this.gbxTrabalho.Location = new System.Drawing.Point(255, 32);
            this.gbxTrabalho.Name = "gbxTrabalho";
            this.gbxTrabalho.Size = new System.Drawing.Size(161, 29);
            this.gbxTrabalho.TabIndex = 9;
            this.gbxTrabalho.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnFisica);
            this.groupBox2.Controls.Add(this.rbnJuridica);
            this.groupBox2.Location = new System.Drawing.Point(226, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 29);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // mtxtNascimento
            // 
            this.mtxtNascimento.Location = new System.Drawing.Point(399, 75);
            this.mtxtNascimento.Mask = "00/00/0000";
            this.mtxtNascimento.Name = "mtxtNascimento";
            this.mtxtNascimento.Size = new System.Drawing.Size(138, 21);
            this.mtxtNascimento.TabIndex = 9;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "SP"});
            this.cbxEstado.Location = new System.Drawing.Point(305, 163);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 23);
            this.cbxEstado.TabIndex = 40;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(348, 265);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 41;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(458, 265);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 300);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.mtxtNascimento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxTrabalho);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.mtxtCelular);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mtxtTelefone);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.t);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmClientes";
            this.Text = "CLIENTE";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbnFisica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mtxtTelefone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbxAtivo;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.RadioButton rbnJuridica;
        private System.Windows.Forms.GroupBox gbxTrabalho;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtNascimento;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
    }
}