using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca
{
    public partial class CadastroLeitor : Form
    {
        public CadastroLeitor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroLeitor_Load(object sender, EventArgs e)
        {

        }

        private void SalvarLeitor(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtEndereco.Text != "") && (txtNumber.Text != "") && (txtTelefone.Text != "") && (txtCPF.Text != ""))
            {
                try
                {
                    string strNome = txtNome.Text;
                    string strEndereco = txtEndereco.Text;
                    int intNumero = Convert.ToInt32(txtNumber.Text);
                    string strTelefone = txtTelefone.Text;
                    string strCPF = txtCPF.Text;

                    LeitorBD leitor = new LeitorBD();

                    leitor.SalvarLeitor(strNome, strEndereco, intNumero, strTelefone, strCPF);

                    MessageBox.Show("LEITOR CADASTRADO COM SUCESSO!");
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtNumber.Clear();
                    txtTelefone.Clear();
                    txtCPF.Clear();
                    txtNome.Focus();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("O campo Nº só pode ser preenchido com números");
                    txtNumber.Focus();
                }
            }
            else
            {
                MessageBox.Show("Verifique se todos os campos foram preenchidos!");
                txtNome.Focus();
            }
        }

        private void LimparCampo(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumber.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtNome.Focus();
        }
    }
}
