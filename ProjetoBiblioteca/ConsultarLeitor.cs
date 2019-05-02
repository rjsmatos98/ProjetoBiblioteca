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
using BLL;
using DTO;

namespace UI
{
    public partial class ConsultarLeitor : Form
    {
        private Leitor leitor;
        private LeitorBLL leitorBLL;
        public ConsultarLeitor()
        {
            InitializeComponent();
            leitorBLL = new LeitorBLL();
            leitor = new Leitor();
            AtualizarGrid();
            txtLeitor.Focus();
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            AtualizarGrid();
        }

        private void ClickButton(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tabela = new DataTable();
                leitorBLL.ExcluirLeitor(leitor.ID).Fill(tabela);
                dgvLeitores.DataSource = tabela;
                txtLeitor.Clear();
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }

        private void SelecionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            leitor.ID = Convert.ToInt32(dgvLeitores.Rows[e.RowIndex].Cells[0].Value);
            leitor.Nome = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[1].Value);
            leitor.Endereco = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[2].Value);
            leitor.Numero = Convert.ToInt32(dgvLeitores.Rows[e.RowIndex].Cells[3].Value);
            leitor.Telefone = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[4].Value);
            leitor.CPF = Convert.ToString(dgvLeitores.Rows[e.RowIndex].Cells[5].Value);
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            CadastrarLeitor FormCadastroLeitor = new CadastrarLeitor();
            FormCadastroLeitor.ReceberDados(leitor);
            FormCadastroLeitor.Show();
            Close();
        }

        public void AtualizarGrid()
        {
            dgvLeitores.DataSource = null;
            dgvLeitores.DataSource = leitorBLL.ConsultarLeitor(txtLeitor.Text);
        }
    }
}
