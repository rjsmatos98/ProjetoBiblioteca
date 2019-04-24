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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void CadastroLeitorClick(object sender, EventArgs e)
        {
            CadastroLeitor frmCadastroLeitor = new CadastroLeitor();
            frmCadastroLeitor.Show();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarLeitor frmConsultaLeitor = new ConsultarLeitor();
            frmConsultaLeitor.Show();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarLivro frmCadastrarLivro = new CadastrarLivro();
            frmCadastrarLivro.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarLivro frmConsultarLivro = new ConsultarLivro();
            frmConsultarLivro.Show();
        }
    }
}
