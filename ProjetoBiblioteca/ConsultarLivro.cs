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
    public partial class ConsultarLivro : Form
    {
        LivroBD livro = new LivroBD();
        int ID, Paginas, Quantidade;
        string Nome, Autor, Genero;

        private void SelecionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            Nome = Convert.ToString(dgvLivros.Rows[e.RowIndex].Cells[0].Value);
            ID = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells[1].Value);
            Autor = Convert.ToString(dgvLivros.Rows[e.RowIndex].Cells[2].Value);
            Genero = Convert.ToString(dgvLivros.Rows[e.RowIndex].Cells[3].Value);
            Paginas = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells[4].Value);
            Quantidade = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells[5].Value);
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            CadastrarLivro frmCadastrarLivro = new CadastrarLivro();
            frmCadastrarLivro.ReceberDados(Nome, ID, Autor, Genero, Paginas, Quantidade);
            frmCadastrarLivro.Show();
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable tabela = new DataTable();
                livro.ExcluirLivro(ID).Fill(tabela);
                dgvLivros.DataSource = tabela;
                txtNome.Clear();
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }
        public ConsultarLivro()
        {
            InitializeComponent();
            txtNome.Focus();
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            string strNome = txtNome.Text;

            DataTable tabela = new DataTable();
            livro.ConsultarLivro(strNome).Fill(tabela);
            dgvLivros.DataSource = tabela;
        }

        private void ConsultarLivro_Load(object sender, EventArgs e)
        {

        }
    }
}
