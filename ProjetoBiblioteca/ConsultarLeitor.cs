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
        LeitorBD leitor = new LeitorBD();

        public ConsultarLeitor()
        {
            InitializeComponent();
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            string strNome = txtLeitor.Text;

            DataTable tabela = new DataTable();
            leitor.ConsultarLeitor(strNome).Fill(tabela);
            dgvLeitores.DataSource = tabela;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string strNome = txtLeitor.Text;

                DataTable tabela = new DataTable();
                leitor.ExcluirLeitor(strNome).Fill(tabela);
                dgvLeitores.DataSource = tabela;
                txtLeitor.Clear();
            }
        }
    }
}
