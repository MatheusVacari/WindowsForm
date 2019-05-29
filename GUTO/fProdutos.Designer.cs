namespace GUTO
{
    partial class frmProdutos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpCodigo = new System.Windows.Forms.TextBox();
            this.txtpNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpVenda = new System.Windows.Forms.TextBox();
            this.txtpLucro = new System.Windows.Forms.TextBox();
            this.txtpCusto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpBarras = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbxpMedida = new System.Windows.Forms.ComboBox();
            this.cbxpMarca = new System.Windows.Forms.ComboBox();
            this.cbxpCategoria = new System.Windows.Forms.ComboBox();
            this.cbxpOrigem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO PRODUTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CÓDIGO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOME:";
            // 
            // txtpCodigo
            // 
            this.txtpCodigo.Location = new System.Drawing.Point(47, 59);
            this.txtpCodigo.Name = "txtpCodigo";
            this.txtpCodigo.Size = new System.Drawing.Size(74, 20);
            this.txtpCodigo.TabIndex = 3;
            // 
            // txtpNome
            // 
            this.txtpNome.Location = new System.Drawing.Point(166, 59);
            this.txtpNome.Name = "txtpNome";
            this.txtpNome.Size = new System.Drawing.Size(359, 20);
            this.txtpNome.TabIndex = 5;
            this.txtpNome.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "LUCRO %:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PREÇO CUSTO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "PREÇO  VENDA:";
            // 
            // txtpVenda
            // 
            this.txtpVenda.Location = new System.Drawing.Point(368, 125);
            this.txtpVenda.Name = "txtpVenda";
            this.txtpVenda.Size = new System.Drawing.Size(157, 20);
            this.txtpVenda.TabIndex = 9;
            // 
            // txtpLucro
            // 
            this.txtpLucro.Location = new System.Drawing.Point(200, 125);
            this.txtpLucro.Name = "txtpLucro";
            this.txtpLucro.Size = new System.Drawing.Size(100, 20);
            this.txtpLucro.TabIndex = 10;
            // 
            // txtpCusto
            // 
            this.txtpCusto.Location = new System.Drawing.Point(47, 125);
            this.txtpCusto.Name = "txtpCusto";
            this.txtpCusto.Size = new System.Drawing.Size(100, 20);
            this.txtpCusto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "UNIDADE MEDIDA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CÓDIGO DE BARRAS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ORIGEM:";
            // 
            // txtpBarras
            // 
            this.txtpBarras.Location = new System.Drawing.Point(368, 192);
            this.txtpBarras.Name = "txtpBarras";
            this.txtpBarras.Size = new System.Drawing.Size(157, 20);
            this.txtpBarras.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "CATEGORIA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "MARCA:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(227, 308);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 31);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(356, 308);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 31);
            this.btnSalvar.TabIndex = 23;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // cbxpMedida
            // 
            this.cbxpMedida.FormattingEnabled = true;
            this.cbxpMedida.Items.AddRange(new object[] {
            "Litros",
            "Kg",
            "Metros"});
            this.cbxpMedida.Location = new System.Drawing.Point(47, 191);
            this.cbxpMedida.Name = "cbxpMedida";
            this.cbxpMedida.Size = new System.Drawing.Size(147, 21);
            this.cbxpMedida.TabIndex = 24;
            // 
            // cbxpMarca
            // 
            this.cbxpMarca.FormattingEnabled = true;
            this.cbxpMarca.Items.AddRange(new object[] {
            "Olokinho meu",
            "Vai que vai"});
            this.cbxpMarca.Location = new System.Drawing.Point(47, 261);
            this.cbxpMarca.Name = "cbxpMarca";
            this.cbxpMarca.Size = new System.Drawing.Size(190, 21);
            this.cbxpMarca.TabIndex = 25;
            // 
            // cbxpCategoria
            // 
            this.cbxpCategoria.FormattingEnabled = true;
            this.cbxpCategoria.Items.AddRange(new object[] {
            "Comida",
            "Bebida",
            "Utiliarios"});
            this.cbxpCategoria.Location = new System.Drawing.Point(334, 261);
            this.cbxpCategoria.Name = "cbxpCategoria";
            this.cbxpCategoria.Size = new System.Drawing.Size(191, 21);
            this.cbxpCategoria.TabIndex = 26;
            // 
            // cbxpOrigem
            // 
            this.cbxpOrigem.FormattingEnabled = true;
            this.cbxpOrigem.Items.AddRange(new object[] {
            "China",
            "Brasil",
            "Japao"});
            this.cbxpOrigem.Location = new System.Drawing.Point(200, 191);
            this.cbxpOrigem.Name = "cbxpOrigem";
            this.cbxpOrigem.Size = new System.Drawing.Size(147, 21);
            this.cbxpOrigem.TabIndex = 27;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 373);
            this.Controls.Add(this.cbxpOrigem);
            this.Controls.Add(this.cbxpCategoria);
            this.Controls.Add(this.cbxpMarca);
            this.Controls.Add(this.cbxpMedida);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpBarras);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpCusto);
            this.Controls.Add(this.txtpLucro);
            this.Controls.Add(this.txtpVenda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpNome);
            this.Controls.Add(this.txtpCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProdutos";
            this.Text = "PRODUTOS";
            this.Load += new System.EventHandler(this.FProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpCodigo;
        private System.Windows.Forms.TextBox txtpNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpVenda;
        private System.Windows.Forms.TextBox txtpLucro;
        private System.Windows.Forms.TextBox txtpCusto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpBarras;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbxpMedida;
        private System.Windows.Forms.ComboBox cbxpMarca;
        private System.Windows.Forms.ComboBox cbxpCategoria;
        private System.Windows.Forms.ComboBox cbxpOrigem;
    }
}