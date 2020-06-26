namespace MVCC16
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCpfC16 = new System.Windows.Forms.TextBox();
            this.txtNomeC16 = new System.Windows.Forms.TextBox();
            this.txtNomeMaeC16 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpfC16
            // 
            this.txtCpfC16.Location = new System.Drawing.Point(142, 56);
            this.txtCpfC16.Name = "txtCpfC16";
            this.txtCpfC16.Size = new System.Drawing.Size(100, 20);
            this.txtCpfC16.TabIndex = 0;
            // 
            // txtNomeC16
            // 
            this.txtNomeC16.Location = new System.Drawing.Point(142, 126);
            this.txtNomeC16.Name = "txtNomeC16";
            this.txtNomeC16.Size = new System.Drawing.Size(100, 20);
            this.txtNomeC16.TabIndex = 1;
            // 
            // txtNomeMaeC16
            // 
            this.txtNomeMaeC16.Location = new System.Drawing.Point(142, 200);
            this.txtNomeMaeC16.Name = "txtNomeMaeC16";
            this.txtNomeMaeC16.Size = new System.Drawing.Size(100, 20);
            this.txtNomeMaeC16.TabIndex = 2;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(91, 252);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(29, 59);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_cpf.TabIndex = 4;
            this.lbl_cpf.Text = "CPF";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 129);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(81, 13);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Mãe";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_cpf);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNomeMaeC16);
            this.Controls.Add(this.txtNomeC16);
            this.Controls.Add(this.txtCpfC16);
            this.Name = "FrmClientes";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCpfC16;
        private System.Windows.Forms.TextBox txtNomeC16;
        private System.Windows.Forms.TextBox txtNomeMaeC16;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label2;
    }
}

