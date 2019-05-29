namespace GUTO
{
    partial class frmSetor
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
            this.txtsCodigo = new System.Windows.Forms.TextBox();
            this.txtsDescricao = new System.Windows.Forms.TextBox();
            this.btnsLimpar = new System.Windows.Forms.Button();
            this.btnsSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE SETORES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CÓDIGO:";
            // 
            // txtsCodigo
            // 
            this.txtsCodigo.Location = new System.Drawing.Point(36, 69);
            this.txtsCodigo.Name = "txtsCodigo";
            this.txtsCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtsCodigo.TabIndex = 3;
            // 
            // txtsDescricao
            // 
            this.txtsDescricao.Location = new System.Drawing.Point(246, 69);
            this.txtsDescricao.Name = "txtsDescricao";
            this.txtsDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtsDescricao.TabIndex = 4;
            // 
            // btnsLimpar
            // 
            this.btnsLimpar.Location = new System.Drawing.Point(91, 109);
            this.btnsLimpar.Name = "btnsLimpar";
            this.btnsLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnsLimpar.TabIndex = 5;
            this.btnsLimpar.Text = "LIMPAR";
            this.btnsLimpar.UseVisualStyleBackColor = true;
            this.btnsLimpar.Click += new System.EventHandler(this.BtnsLimpar_Click);
            // 
            // btnsSalvar
            // 
            this.btnsSalvar.Location = new System.Drawing.Point(204, 109);
            this.btnsSalvar.Name = "btnsSalvar";
            this.btnsSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsSalvar.TabIndex = 6;
            this.btnsSalvar.Text = "SALVAR";
            this.btnsSalvar.UseVisualStyleBackColor = true;
            this.btnsSalvar.Click += new System.EventHandler(this.BtnsSalvar_Click);
            // 
            // frmSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 158);
            this.Controls.Add(this.btnsSalvar);
            this.Controls.Add(this.btnsLimpar);
            this.Controls.Add(this.txtsDescricao);
            this.Controls.Add(this.txtsCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSetor";
            this.Text = "SETOR";
            this.Load += new System.EventHandler(this.FrmSetor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsCodigo;
        private System.Windows.Forms.TextBox txtsDescricao;
        private System.Windows.Forms.Button btnsLimpar;
        private System.Windows.Forms.Button btnsSalvar;
    }
}