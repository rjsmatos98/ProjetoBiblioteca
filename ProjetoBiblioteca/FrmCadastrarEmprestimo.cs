using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace UI
{
    public partial class FrmCadastrarEmprestimo : Form
    {
        int selecao;
        Emprestimo emprestimo;
        EmprestimoBLL emprestimoBLL;
        LeitorBLL leitorBLL;
        LivroBLL livroBLL;
        public FrmCadastrarEmprestimo()
        {
            InitializeComponent();
            emprestimo = new Emprestimo();
            emprestimoBLL = new EmprestimoBLL();
            leitorBLL = new LeitorBLL();
            livroBLL = new LivroBLL();
            txtRetirada.Text = DateTime.Now.ToShortDateString();
            txtDevolucao.Text = DateTime.Now.AddDays(7).ToShortDateString();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtIDLivro.Text != "") && (txtIDLeitor.Text != ""))
            {
                try
                {
                    emprestimo.Leitor.Nome = Convert.ToString(lblLeitor.Text);
                    emprestimo.Livro.Nome = Convert.ToString(lblLivro.Text);
                    emprestimo.Leitor.ID = Convert.ToInt32(txtIDLeitor.Text);
                    emprestimo.Livro.ID = Convert.ToInt32(txtIDLivro.Text);
                    emprestimo.Retirada = txtRetirada.Text;
                    emprestimo.Devolucao = txtDevolucao.Text;

                    emprestimoBLL.SalvarEmprestimo(emprestimo);

                    MessageBox.Show("Emprestimo cadastrado com Sucesso!");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Verifique se algum campo está em branco");
                }
            }

            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtLeitor.Focus();
            }
        }

        private void DgvLivrosLeitores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();

            selecao = 1;
        }

        private void TxtLivro_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();

            selecao = 2;
        }

        private void SelecionarRegistros(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (selecao == 1)
                {
                    txtLeitor.Clear();
                    int intLeitorID = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[0].Value);
                    txtIDLeitor.Text = Convert.ToString(intLeitorID);
                    string strLeitor = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[1].Value);
                    lblLeitor.Text = strLeitor;
                    dgvLivrosLeitores.DataSource = null;
                }

                else if (selecao == 2)
                {
                    txtLivro.Clear();
                    int intLivroID = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[0].Value);
                    txtIDLivro.Text = Convert.ToString(intLivroID);
                    string strLivro = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[1].Value);
                    lblLivro.Text = strLivro;
                    dgvLivrosLeitores.DataSource = null;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                dgvLivrosLeitores.DataSource = null;
                MessageBox.Show("A coluna não é um registro valido para seleção");
            }
        }
        public void AtualizarGrid()
        {
            if (selecao == 1)
            {
                dgvLivrosLeitores.DataSource = null;
                dgvLivrosLeitores.DataSource = leitorBLL.ConsultarLeitor(txtLeitor.Text);
            }
            else if (selecao == 2)
            {
                dgvLivrosLeitores.DataSource = null;
                dgvLivrosLeitores.DataSource = livroBLL.ConsultarLivros(txtLivro.Text);
            }
        }
    }
}
