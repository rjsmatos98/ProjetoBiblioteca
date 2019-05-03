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
    public partial class FrmConsultarLivro : Form
    {
        Livro livro;
        LivroBLL livroBLL;
        public FrmConsultarLivro()
        {
            InitializeComponent();
            livro = new Livro();
            livroBLL = new LivroBLL();
            AtualizarGrid();
            txtNome.Focus();
        }
        private void SelecionarRegistro(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                livro.ID = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells[0].Value);
                livro.Nome = Convert.ToString(dgvLivros.Rows[e.RowIndex].Cells[1].Value);
                livro.Autor = Convert.ToString(dgvLivros.Rows[e.RowIndex].Cells[2].Value);
                livro.Genero = Convert.ToString(dgvLivros.Rows[e.RowIndex].Cells[3].Value);
                livro.Paginas = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells[4].Value);
                livro.Quantidade = Convert.ToInt32(dgvLivros.Rows[e.RowIndex].Cells[5].Value);
                btnExcluir.Enabled = true;
                btnAlterar.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("A coluna não é um registro valido para seleção");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            FrmCadastrarLivro frmCadastrarLivro = new FrmCadastrarLivro();
            frmCadastrarLivro.ReceberDados(livro);
            frmCadastrarLivro.Show();
            Close();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                livroBLL.ExcluirLIvro(livro.ID);
                AtualizarGrid();
                txtNome.Clear();
                btnExcluir.Enabled = false;
                btnAlterar.Enabled = false;
            }
        }


        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            AtualizarGrid();
        }

        private void ConsultarLivro_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }
        public void AtualizarGrid()
        {
            dgvLivros.DataSource = null;
            dgvLivros.DataSource = livroBLL.ConsultarLivros(txtNome.Text);
        }

        private void ClickButton(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
        }
    }
}
