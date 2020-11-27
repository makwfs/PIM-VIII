namespace SistemaMysql.View
{
    partial class TelaInicial
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
            this.btnCadastrarInicial = new System.Windows.Forms.Button();
            this.btnPesquisarInicial = new System.Windows.Forms.Button();
            this.btnEditarInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarInicial
            // 
            this.btnCadastrarInicial.Location = new System.Drawing.Point(46, 41);
            this.btnCadastrarInicial.Name = "btnCadastrarInicial";
            this.btnCadastrarInicial.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarInicial.TabIndex = 0;
            this.btnCadastrarInicial.Text = "Cadastrar";
            this.btnCadastrarInicial.UseVisualStyleBackColor = true;
            this.btnCadastrarInicial.Click += new System.EventHandler(this.btnCadastrarInicial_Click);
            // 
            // btnPesquisarInicial
            // 
            this.btnPesquisarInicial.Location = new System.Drawing.Point(127, 41);
            this.btnPesquisarInicial.Name = "btnPesquisarInicial";
            this.btnPesquisarInicial.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarInicial.TabIndex = 1;
            this.btnPesquisarInicial.Text = "Pesquisar";
            this.btnPesquisarInicial.UseVisualStyleBackColor = true;
            this.btnPesquisarInicial.Click += new System.EventHandler(this.btnPesquisarInicial_Click);
            // 
            // btnEditarInicial
            // 
            this.btnEditarInicial.Location = new System.Drawing.Point(208, 41);
            this.btnEditarInicial.Name = "btnEditarInicial";
            this.btnEditarInicial.Size = new System.Drawing.Size(75, 23);
            this.btnEditarInicial.TabIndex = 2;
            this.btnEditarInicial.Text = "Editar";
            this.btnEditarInicial.UseVisualStyleBackColor = true;
            this.btnEditarInicial.Click += new System.EventHandler(this.btnEditarInicial_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 98);
            this.Controls.Add(this.btnEditarInicial);
            this.Controls.Add(this.btnPesquisarInicial);
            this.Controls.Add(this.btnCadastrarInicial);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarInicial;
        private System.Windows.Forms.Button btnPesquisarInicial;
        private System.Windows.Forms.Button btnEditarInicial;
    }
}