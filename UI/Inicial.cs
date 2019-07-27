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
            FrmCadastrarLeitor frmCadastroLeitor = new FrmCadastrarLeitor();
            frmCadastroLeitor.Show();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarLeitor frmConsultaLeitor = new FrmConsultarLeitor();
            frmConsultaLeitor.Show();
        }

        private void IncluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarLivro frmCadastrarLivro = new FrmCadastrarLivro();
            frmCadastrarLivro.Show();
        }

        private void ConsultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarLivro frmConsultarLivro = new FrmConsultarLivro();
            frmConsultarLivro.Show();
        }

        private void InserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastrarEmprestimo frmCadastrarEmprestimo = new FrmCadastrarEmprestimo();
            frmCadastrarEmprestimo.Show();
        }

        private void ExcluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmDevolucao frmDevolucao = new FrmDevolucao();
            frmDevolucao.Show();
        }

        private void ConsultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultarEmprestimo frmConsultarEmprestimo = new FrmConsultarEmprestimo();
            frmConsultarEmprestimo.Show();
        }
    }
}
