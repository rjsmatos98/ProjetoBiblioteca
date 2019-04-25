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
    public partial class Devolucao : Form
    {
        DevolucaoBD devolucao = new DevolucaoBD();
        EmprestimoBD emprestimo = new EmprestimoBD();

        int intIDEmprestimo, intIDLeitor, intIDLivro;
        string strLeitor, strLivro, strRetirada, strDevolucao;
        public Devolucao()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            intIDLeitor = Convert.ToInt32(txtIDLeitor.Text);
            intIDLivro = Convert.ToInt32(txtIDLivro.Text);
            strLeitor = lblLeitor.Text;
            strLivro = lblLivro.Text;
            strRetirada = txtRetirada.Text;
            strDevolucao = txtDevolucao.Text;

            devolucao.SalvarDevolucao(intIDEmprestimo, intIDLeitor, intIDLivro, strLeitor, strLivro, strRetirada, strDevolucao);

            MessageBox.Show("Devolução cadastrada com Sucesso!");
        }

        private void SelecionarRegistros(object sender, DataGridViewCellEventArgs e)
        {
            strLeitor = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[0].Value);
            lblLeitor.Text = strLeitor;


            strLivro = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[1].Value);
            lblLivro.Text = strLivro;

            strRetirada = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[2].Value);
            txtRetirada.Text = strRetirada;

            strDevolucao = Convert.ToString(dgvLivrosLeitores.Rows[e.RowIndex].Cells[3].Value);
            txtDevolucao.Text = strDevolucao;

            intIDEmprestimo = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[4].Value);

            intIDLeitor = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[5].Value);
            txtIDLeitor.Text = Convert.ToString(intIDLeitor);

            intIDLivro = Convert.ToInt32(dgvLivrosLeitores.Rows[e.RowIndex].Cells[6].Value);
            txtIDLivro.Text = Convert.ToString(intIDLivro);

            DateTime atual = DateTime.Now;
            DateTime devolucao = Convert.ToDateTime(strDevolucao);
            int result = DateTime.Compare(devolucao, atual);

            if (result < 0)
            {
                TimeSpan resultado = atual - devolucao;
                Double multa = resultado.Days * 1.3;
                txtAtraso.Text = Convert.ToString(resultado.Days);
                txtMulta.Text = multa.ToString("F2");
            }
            else
            {
                txtAtraso.Text = Convert.ToString("0");
                txtMulta.Text = Convert.ToString("");
            }
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            strLeitor = txtLeitor.Text;

            DataTable tabela = new DataTable();
            emprestimo.ConsultarEmprestimo(strLeitor).Fill(tabela);
            dgvLivrosLeitores.DataSource = tabela;
        }

        private void Devolucao_Load(object sender, EventArgs e)
        {

        }
    }
}
