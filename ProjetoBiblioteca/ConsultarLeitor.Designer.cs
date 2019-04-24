namespace ProjetoBiblioteca
{
    partial class ConsultarLeitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarLeitor));
            this.lbLeitor = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.dgvLeitores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLeitor
            // 
            this.lbLeitor.AutoSize = true;
            this.lbLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbLeitor.Location = new System.Drawing.Point(9, 15);
            this.lbLeitor.Name = "lbLeitor";
            this.lbLeitor.Size = new System.Drawing.Size(49, 18);
            this.lbLeitor.TabIndex = 0;
            this.lbLeitor.Text = "Leitor:";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLeitor.Location = new System.Drawing.Point(58, 12);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.Size = new System.Drawing.Size(459, 24);
            this.txtLeitor.TabIndex = 2;
            this.txtLeitor.TextChanged += new System.EventHandler(this.TxtLeitor_TextChanged);
            // 
            // dgvLeitores
            // 
            this.dgvLeitores.AllowUserToAddRows = false;
            this.dgvLeitores.AllowUserToDeleteRows = false;
            this.dgvLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitores.Location = new System.Drawing.Point(12, 72);
            this.dgvLeitores.Name = "dgvLeitores";
            this.dgvLeitores.ReadOnly = true;
            this.dgvLeitores.Size = new System.Drawing.Size(505, 150);
            this.dgvLeitores.TabIndex = 4;
            // 
            // ConsultarLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 233);
            this.Controls.Add(this.dgvLeitores);
            this.Controls.Add(this.txtLeitor);
            this.Controls.Add(this.lbLeitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultarLeitor";
            this.Text = "Consultar Leitor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLeitor;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.DataGridView dgvLeitores;
    }
}