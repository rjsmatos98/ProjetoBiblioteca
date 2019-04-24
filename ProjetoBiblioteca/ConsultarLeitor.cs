using MySql.Data.MySqlClient;
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
    public partial class ConsultarLeitor : Form
    {
        LeitorBD leitor = new LeitorBD();
        int ID, Numero;
        string Nome, Endereco, Telefone, CPF;
        public ConsultarLeitor()
        {
            InitializeComponent();
            txtLeitor.Focus();
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            string strNome = txtLeitor.Text;

            DataTable tabela = new DataTable();
            leitor.ConsultarLeitor(strNome).Fill(tabela);
            dgvLeitores.DataSource = tabela;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tabela = new DataTable();
                leitor.ExcluirLeitor(ID).Fill(tabela);
                dgvLeitores.DataSource = tabela;
                txtLeitor.Clear();
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void SelecionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            Nome = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[0].Value);
            ID = Convert.ToInt32(dgvLeitores.Rows[e.RowIndex].Cells[1].Value);
            Endereco = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[2].Value);
            Numero = Convert.ToInt32(dgvLeitores.Rows[e.RowIndex].Cells[3].Value);
            Telefone = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[4].Value);
            CPF = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[5].Value);
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            CadastroLeitor FormCadastroLeitor = new CadastroLeitor();
            FormCadastroLeitor.ReceberDados(Nome, ID, Endereco, Numero, Telefone, CPF);
            FormCadastroLeitor.Show();
            Close();
        }
    }
}
