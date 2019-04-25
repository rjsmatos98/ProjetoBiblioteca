using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class ConsultarEmprestimo : Form
    {
        int codigo_emprestimo;
        EmprestimoBD emprestimo = new EmprestimoBD();
        public ConsultarEmprestimo()
        {
            InitializeComponent();
            btnExcluir.Enabled = false;
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            string strLeitor = txtLeitor.Text;

            DataTable tabela = new DataTable();
            emprestimo.ConsultarEmprestimo(strLeitor).Fill(tabela);
            dgvEmprestimos.DataSource = tabela;
        }

        private void SelecionarRegistros(object sender, DataGridViewCellEventArgs e)
        {
            codigo_emprestimo = Convert.ToInt32(dgvEmprestimos.Rows[e.RowIndex].Cells[4].Value);
            btnExcluir.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Deleta registro


                emprestimo.ExcluirEmprestimo(codigo_emprestimo);
                txtLeitor.Text = "";


                string strLeitor = txtLeitor.Text;
                DataTable table = new DataTable();
                emprestimo.ConsultarEmprestimo(strLeitor).Fill(table);
                dgvEmprestimos.DataSource = table;
                btnExcluir.Enabled = false;

            }
        }
    }
}
