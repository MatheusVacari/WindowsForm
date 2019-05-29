namespace GUTO
{
    partial class frmCargos
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
            this.btncSalvar = new System.Windows.Forms.Button();
            this.btncLimpar = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcDescricao = new System.Windows.Forms.TextBox();
            this.txtcCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncSalvar
            // 
            this.btncSalvar.Location = new System.Drawing.Point(120, 107);
            this.btncSalvar.Name = "btncSalvar";
            this.btncSalvar.Size = new System.Drawing.Size(92, 42);
            this.btncSalvar.TabIndex = 0;
            this.btncSalvar.Text = "SALVAR";
            this.btncSalvar.UseVisualStyleBackColor = true;
            this.btncSalvar.Click += new System.EventHandler(this.BtncSalvar_Click);
            // 
            // btncLimpar
            // 
            this.btncLimpar.Location = new System.Drawing.Point(12, 107);
            this.btncLimpar.Name = "btncLimpar";
            this.btncLimpar.Size = new System.Drawing.Size(92, 42);
            this.btncLimpar.TabIndex = 1;
            this.btncLimpar.Text = "LIMPAR";
            this.btncLimpar.UseVisualStyleBackColor = true;
            this.btncLimpar.Click += new System.EventHandler(this.BtncLimpar_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCadastro.Location = new System.Drawing.Point(16, 16);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(222, 22);
            this.lblCadastro.TabIndex = 2;
            this.lblCadastro.Text = "CADASTRO DE CLIENTES";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(17, 49);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // txtcDescricao
            // 
            this.txtcDescricao.Location = new System.Drawing.Point(120, 65);
            this.txtcDescricao.Name = "txtcDescricao";
            this.txtcDescricao.Size = new System.Drawing.Size(118, 20);
            this.txtcDescricao.TabIndex = 5;
            // 
            // txtcCodigo
            // 
            this.txtcCodigo.Location = new System.Drawing.Point(20, 65);
            this.txtcCodigo.Name = "txtcCodigo";
            this.txtcCodigo.Size = new System.Drawing.Size(59, 20);
            this.txtcCodigo.TabIndex = 6;
            // 
            // frmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 188);
            this.Controls.Add(this.txtcCodigo);
            this.Controls.Add(this.txtcDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.btncLimpar);
            this.Controls.Add(this.btncSalvar);
            this.Name = "frmCargos";
            this.Text = "CARGOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncSalvar;
        private System.Windows.Forms.Button btncLimpar;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcDescricao;
        private System.Windows.Forms.TextBox txtcCodigo;
    }
}