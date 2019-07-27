using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmDevolucao : Form
    {
        Emprestimo emprestimo;
        EmprestimoBLL emprestimoBLL;
        public FrmDevolucao()
        {
            InitializeComponent();
            emprestimo = new Emprestimo();
            emprestimoBLL = new EmprestimoBLL();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            emprestimoBLL.SalvarDevolucao(emprestimo);

            MessageBox.Show("Devolução realizada com Sucesso!");
        }

        private void SelecionarRegistros(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Devolucao_Load(object sender, EventArgs e)
        {

        }

        public void ReceberDados(Emprestimo emprestimo)
        {
            txtIDLeitor.Text = Convert.ToString(emprestimo.Leitor.ID);
            txtIDLivro.Text = Convert.ToString(emprestimo.Livro.ID);
            txtLeitor.Text = emprestimo.Leitor.Nome;
            txtLivro.Text = emprestimo.Livro.Nome;
            txtRetirada.Text = emprestimo.Retirada;
            txtDevolucao.Text = emprestimo.Devolucao;

            DateTime atual = DateTime.Now;
            DateTime devolucao = Convert.ToDateTime(txtDevolucao.Text);
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
    }
}
