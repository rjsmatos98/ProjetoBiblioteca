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
        LeitorBD leitor = new LeitorBD();
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
            if (txtId.Text == "")
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

                        leitor.SalvarLeitor(strNome, strEndereco, intNumero, strTelefone, strCPF);

                        MessageBox.Show("LEITOR CADASTRADO COM SUCESSO!");
                        txtId.Clear();
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
            else
            {
                int intId = Convert.ToInt32(txtId.Text);
                string strNome = txtNome.Text;
                string strEndereco = txtEndereco.Text;
                int intNumero = Convert.ToInt32(txtNumber.Text);
                string strTelefone = txtTelefone.Text;
                string strCPF = txtCPF.Text;

                leitor.AlterarLeitor(intId, strNome, strEndereco, intNumero, strTelefone, strCPF);
                MessageBox.Show("DADOS DO LEITOR ALTERADO COM SUCESSO!");

                ConsultarLeitor FormConsultarLeitor = new ConsultarLeitor();
                FormConsultarLeitor.Show();
                Close();
            }
        }

        private void LimparCampo(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumber.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtNome.Focus();
        }

        public void ReceberDados(string strNome, int intId, string strEndereco, int intNumero, string strTelefone, string strCPF)
        {

            txtId.Text = Convert.ToString(intId);
            txtNome.Text = strNome;
            txtEndereco.Text = strEndereco;
            txtNumber.Text = Convert.ToString(intNumero);
            txtTelefone.Text = strTelefone;
            txtCPF.Text = strCPF;

        }
    }
}
