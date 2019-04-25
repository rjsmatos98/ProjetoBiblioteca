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
    public partial class CadastrarEmprestimo : Form
    {
        int selecao, intIDLeitor, intIDLivro;
        string strLeitor, strLivro, strRetirada, strDevolucao;
        EmprestimoBD emprestimo = new EmprestimoBD();
        LeitorBD leitor = new LeitorBD();
        LivroBD livro = new LivroBD();

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtIDLivro.Text != "") && (txtIDLeitor.Text != ""))
            {


                strLeitor = lblLeitor.Text;
                strLivro = lblLivro.Text;
                intIDLeitor = Convert.ToInt32(txtIDLeitor.Text);
                intIDLivro = Convert.ToInt32(txtIDLivro.Text);
                strRetirada = txtRetirada.Text;
                strDevolucao = txtDevolucao.Text;

                emprestimo.SalvarEmprestimo(intIDLeitor, intIDLivro, strLeitor, strLivro, strRetirada, strDevolucao);

                MessageBox.Show("Emprestimo cadastrado com Sucesso!");

            }

            else
            {
                MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                txtLeitor.Focus();
            }
        }

        private void dgvLivrosLeitores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelecionarRegistros(object sender, DataGridViewCellEventArgs e)
        {
            if (selecao == 1)
            {

                intIDLeitor = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[1].Value);
                txtIDLeitor.Text = Convert.ToString(intIDLeitor);
                strLeitor = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[0].Value);
                lblLeitor.Text = strLeitor;

            }

            if (selecao == 2)
            {

                intIDLivro = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[1].Value);
                txtIDLivro.Text = Convert.ToString(intIDLivro);
                strLivro = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[0].Value);
                lblLivro.Text = strLivro;

            }
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            strLeitor = txtLeitor.Text;
            DataTable tabela = new DataTable();
            leitor.ConsultarLeitor(strLeitor).Fill(tabela);
            dgvLivrosLeitores.DataSource = tabela;

            selecao = 1;
        }

        private void TxtLivro_TextChanged(object sender, EventArgs e)
        {
            strLivro = txtLivro.Text;
            DataTable tabela = new DataTable();
            livro.ConsultarLivro(strLivro).Fill(tabela);
            dgvLivrosLeitores.DataSource = tabela;

            selecao = 2;
        }
        public CadastrarEmprestimo()
        {
            InitializeComponent();
            txtRetirada.Text = DateTime.Now.ToShortDateString();
            txtDevolucao.Text = DateTime.Now.AddDays(7).ToShortDateString();    
        }
    }
}
