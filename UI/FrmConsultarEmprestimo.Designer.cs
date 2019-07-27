namespace UI
{
    partial class FrmConsultarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarEmprestimo));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.lbLeitor = new System.Windows.Forms.Label();
            this.btnDevolucao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(12, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 55);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AllowUserToDeleteRows = false;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(12, 44);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.ReadOnly = true;
            this.dgvEmprestimos.Size = new System.Drawing.Size(505, 171);
            this.dgvEmprestimos.TabIndex = 8;
            this.dgvEmprestimos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelecionarRegistros);
            // 
            // txtLeitor
            // 
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLeitor.Location = new System.Drawing.Point(58, 6);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(459, 24);
            this.txtLeitor.TabIndex = 7;
            this.txtLeitor.TextChanged += new System.EventHandler(this.TxtLeitor_TextChanged);
            // 
            // lbLeitor
            // 
            this.lbLeitor.AutoSize = true;
            this.lbLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbLeitor.Location = new System.Drawing.Point(9, 9);
            this.lbLeitor.Name = "lbLeitor";
            this.lbLeitor.Size = new System.Drawing.Size(49, 18);
            this.lbLeitor.TabIndex = 6;
            this.lbLeitor.Text = "Leitor:";
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucao.Image")));
            this.btnDevolucao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevolucao.Location = new System.Drawing.Point(450, 221);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(67, 55);
            this.btnDevolucao.TabIndex = 10;
            this.btnDevolucao.Text = "Devolução";
            this.btnDevolucao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.BtnDevolucao_Click);
            // 
            // FrmConsultarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 286);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvEmprestimos);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.lbLeitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarEmprestimo";
            this.Text = "Consultar Emprestimo";
            this.Load += new System.EventHandler(this.FrmConsultarEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.Label lbLeitor;
        private System.Windows.Forms.Button btnDevolucao;
    }
}