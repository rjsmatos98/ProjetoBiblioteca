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

namespace ProjetoBiblioteca
{
    public partial class ConsultarLeitor : Form
    {
        public ConsultarLeitor()
        {
            InitializeComponent();
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            LeitorBD leitor = new LeitorBD();
            Conexao banco = new Conexao();

            string strNome = txtLeitor.Text;

            DataTable tabela = new DataTable();
            leitor.ConsultarLeitor(strNome).Fill(tabela);
            dgvLeitores.DataSource = tabela;
        }
    }
}
