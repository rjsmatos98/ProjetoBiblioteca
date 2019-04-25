namespace ProjetoBiblioteca
{
    partial class CadastrarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEmprestimo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.txtIDLeitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.txtIDLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLivro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.dgvLivrosLeitores = new System.Windows.Forms.DataGridView();
            this.txtRetirada = new System.Windows.Forms.MaskedTextBox();
            this.txtDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leitor:";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLeitor.Location = new System.Drawing.Point(53, 14);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(349, 24);
            this.txtLeitor.TabIndex = 1;
            this.txtLeitor.TextChanged += new System.EventHandler(this.TxtLeitor_TextChanged);
            // 
            // txtIDLeitor
            // 
            this.txtIDLeitor.Enabled = false;
            this.txtIDLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIDLeitor.Location = new System.Drawing.Point(439, 14);
            this.txtIDLeitor.Name = "txtIDLeitor";
            this.txtIDLeitor.Size = new System.Drawing.Size(134, 24);
            this.txtIDLeitor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(413, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // lblLeitor
            // 
            this.lblLeitor.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLeitor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLeitor.Location = new System.Drawing.Point(13, 51);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(389, 41);
            this.lblLeitor.TabIndex = 4;
            this.lblLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDLivro
            // 
            this.txtIDLivro.Enabled = false;
            this.txtIDLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIDLivro.Location = new System.Drawing.Point(439, 108);
            this.txtIDLivro.Name = "txtIDLivro";
            this.txtIDLivro.Size = new System.Drawing.Size(134, 24);
            this.txtIDLivro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(414, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // txtLivro
            // 
            this.txtLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLivro.Location = new System.Drawing.Point(53, 108);
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.Size = new System.Drawing.Size(349, 24);
            this.txtLivro.TabIndex = 3;
            this.txtLivro.TextChanged += new System.EventHandler(this.TxtLivro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(10, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Livro:";
            // 
            // lblLivro
            // 
            this.lblLivro.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLivro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLivro.Location = new System.Drawing.Point(13, 148);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(389, 41);
            this.lblLivro.TabIndex = 9;
            this.lblLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLivrosLeitores
            // 
            this.dgvLivrosLeitores.AllowUserToAddRows = false;
            this.dgvLivrosLeitores.AllowUserToDeleteRows = false;
            this.dgvLivrosLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivrosLeitores.Location = new System.Drawing.Point(13, 209);
            this.dgvLivrosLeitores.Name = "dgvLivrosLeitores";
            this.dgvLivrosLeitores.ReadOnly = true;
            this.dgvLivrosLeitores.Size = new System.Drawing.Size(389, 141);
            this.dgvLivrosLeitores.TabIndex = 10;
            this.dgvLivrosLeitores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionarRegistros);
            this.dgvLivrosLeitores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivrosLeitores_CellContentClick);
            // 
            // txtRetirada
            // 
            this.txtRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRetirada.Location = new System.Drawing.Point(491, 209);
            this.txtRetirada.Mask = "00/00/0000";
            this.txtRetirada.Name = "txtRetirada";
            this.txtRetirada.Size = new System.Drawing.Size(82, 24);
            this.txtRetirada.TabIndex = 5;
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDevolucao.Location = new System.Drawing.Point(491, 253);
            this.txtDevolucao.Mask = "00/00/0000";
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(82, 24);
            this.txtDevolucao.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(423, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Retirada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(407, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Devolução:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(511, 296);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(62, 54);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // CadastrarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 362);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.txtRetirada);
            this.Controls.Add(this.dgvLivrosLeitores);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.txtIDLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.txtIDLeitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarEmprestimo";
            this.Text = "Cadastrar Empréstimo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosLeitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.TextBox txtIDLeitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.TextBox txtIDLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.DataGridView dgvLivrosLeitores;
        private System.Windows.Forms.MaskedTextBox txtRetirada;
        private System.Windows.Forms.MaskedTextBox txtDevolucao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
    }
}