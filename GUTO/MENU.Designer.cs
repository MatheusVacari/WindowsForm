namespace GUTO
{
    partial class fMenu
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnSetor = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClientes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.DarkRed;
            this.btnClientes.Location = new System.Drawing.Point(12, 36);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(169, 58);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CADASTRO CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargo.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCargo.Location = new System.Drawing.Point(221, 117);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(169, 58);
            this.btnCargo.TabIndex = 1;
            this.btnCargo.Text = "CADASTRO CARGOS";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.BtnCargo_Click);
            // 
            // btnSetor
            // 
            this.btnSetor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetor.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSetor.Location = new System.Drawing.Point(221, 36);
            this.btnSetor.Name = "btnSetor";
            this.btnSetor.Size = new System.Drawing.Size(169, 58);
            this.btnSetor.TabIndex = 2;
            this.btnSetor.Text = "CADASTRO SETOR";
            this.btnSetor.UseVisualStyleBackColor = true;
            this.btnSetor.Click += new System.EventHandler(this.BtnSetor_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFuncionario.Location = new System.Drawing.Point(12, 117);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(169, 58);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "CADASTRO FUNCIOÁRIOS";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAjuda.Location = new System.Drawing.Point(221, 199);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(169, 58);
            this.btnAjuda.TabIndex = 4;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.BtnAjuda_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProdutos.Location = new System.Drawing.Point(12, 199);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(169, 58);
            this.btnProdutos.TabIndex = 5;
            this.btnProdutos.Text = "CADASTRO PRODUTOS";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 325);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnSetor);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnClientes);
            this.Name = "fMenu";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.FMENU_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnSetor;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Button btnProdutos;
    }
}