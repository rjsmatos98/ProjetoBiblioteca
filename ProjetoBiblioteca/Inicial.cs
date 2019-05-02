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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void CadastroLeitorClick(object sender, EventArgs e)
        {
            CadastrarLeitor frmCadastroLeitor = new CadastrarLeitor();
            frmCadastroLeitor.Show();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLeitor frmConsultaLeitor = new ConsultarLeitor();
            frmConsultaLeitor.Show();
        }

        private void IncluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarLivro frmCadastrarLivro = new CadastrarLivro();
            frmCadastrarLivro.Show();
        }

        private void ConsultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarLivro frmConsultarLivro = new ConsultarLivro();
            frmConsultarLivro.Show();
        }

        private void InserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarEmprestimo frmCadastrarEmprestimo = new CadastrarEmprestimo();
            frmCadastrarEmprestimo.Show();
        }

        private void ExcluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Devolucao frmDevolucao = new Devolucao();
            frmDevolucao.Show();
        }

        private void ConsultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarEmprestimo frmConsultarEmprestimo = new ConsultarEmprestimo();
            frmConsultarEmprestimo.Show();
        }
    }
}
