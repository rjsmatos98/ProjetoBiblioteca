namespace ProjetoBiblioteca
{
    partial class Devolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucao));
            this.lblLeitor = new System.Windows.Forms.Label();
            this.txtIDLeitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.txtIDLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLivrosLeitores = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.txtRetirada = new System.Windows.Forms.MaskedTextBox();
            this.txtAtraso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMulta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLeitor
            // 
            this.lblLeitor.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLeitor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLeitor.Location = new System.Drawing.Point(14, 44);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(345, 41);
            this.lblLeitor.TabIndex = 9;
            this.lblLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDLeitor
            // 
            this.txtIDLeitor.Enabled = false;
            this.txtIDLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIDLeitor.Location = new System.Drawing.Point(389, 12);
            this.txtIDLeitor.Name = "txtIDLeitor";
            this.txtIDLeitor.Size = new System.Drawing.Size(119, 24);
            this.txtIDLeitor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(363, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLeitor.Location = new System.Drawing.Point(59, 12);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(300, 24);
            this.txtLeitor.TabIndex = 6;
            this.txtLeitor.TextChanged += new System.EventHandler(this.TxtLeitor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Leitor:";
            // 
            // lblLivro
            // 
            this.lblLivro.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLivro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLivro.Location = new System.Drawing.Point(56, 93);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(303, 48);
            this.lblLivro.TabIndex = 13;
            this.lblLivro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDLivro
            // 
            this.txtIDLivro.Enabled = false;
            this.txtIDLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIDLivro.Location = new System.Drawing.Point(389, 93);
            this.txtIDLivro.Name = "txtIDLivro";
            this.txtIDLivro.Size = new System.Drawing.Size(119, 24);
            this.txtIDLivro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(364, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Livro:";
            // 
            // dgvLivrosLeitores
            // 
            this.dgvLivrosLeitores.AllowUserToAddRows = false;
            this.dgvLivrosLeitores.AllowUserToDeleteRows = false;
            this.dgvLivrosLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivrosLeitores.Location = new System.Drawing.Point(14, 150);
            this.dgvLivrosLeitores.Name = "dgvLivrosLeitores";
            this.dgvLivrosLeitores.ReadOnly = true;
            this.dgvLivrosLeitores.Size = new System.Drawing.Size(692, 200);
            this.dgvLivrosLeitores.TabIndex = 14;
            this.dgvLivrosLeitores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionarRegistros);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(540, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Devolução:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(556, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Retirada:";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDevolucao.Location = new System.Drawing.Point(624, 44);
            this.txtDevolucao.Mask = "00/00/0000";
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(82, 24);
            this.txtDevolucao.TabIndex = 16;
            // 
            // txtRetirada
            // 
            this.txtRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtRetirada.Location = new System.Drawing.Point(624, 15);
            this.txtRetirada.Mask = "00/00/0000";
            this.txtRetirada.Name = "txtRetirada";
            this.txtRetirada.Size = new System.Drawing.Size(82, 24);
            this.txtRetirada.TabIndex = 15;
            // 
            // txtAtraso
            // 
            this.txtAtraso.Enabled = false;
            this.txtAtraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAtraso.Location = new System.Drawing.Point(624, 74);
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(82, 24);
            this.txtAtraso.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(514, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dias de Atraso:";
            // 
            // txtMulta
            // 
            this.txtMulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMulta.Location = new System.Drawing.Point(624, 104);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(82, 24);
            this.txtMulta.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(552, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Multa R$:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(328, 359);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(62, 54);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // Devolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 425);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAtraso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDevolucao);
            this.Controls.Add(this.txtRetirada);
            this.Controls.Add(this.dgvLivrosLeitores);
            this.Controls.Add(this.lblLivro);
            this.Controls.Add(this.txtIDLivro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.txtIDLeitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Devolucao";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.Devolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosLeitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.TextBox txtIDLeitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.TextBox txtIDLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvLivrosLeitores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDevolucao;
        private System.Windows.Forms.MaskedTextBox txtRetirada;
        private System.Windows.Forms.TextBox txtAtraso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrar;
    }
}