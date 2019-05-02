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
using BLL;
using DTO;
using System.Windows.Forms;

namespace UI
{
    public partial class CadastrarLeitor : Form
    {
        Leitor leitor;
        LeitorBLL leitorBLL;
        public CadastrarLeitor()
        {
            InitializeComponent();
            leitorBLL = new LeitorBLL();
            leitor = new Leitor();
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
                        leitor.Nome = txtNome.Text;
                        leitor.Endereco = txtEndereco.Text;
                        leitor.Numero = Convert.ToInt32(txtNumber.Text);
                        leitor.Telefone = txtTelefone.Text;
                        leitor.CPF = txtCPF.Text;

                        leitorBLL.IncluirLeitor(leitor);

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
                leitor.ID = int.Parse(txtId.Text);
                leitor.Nome = txtNome.Text;
                leitor.Endereco = txtEndereco.Text;
                leitor.Numero = int.Parse(txtNumber.Text);
                leitor.Telefone = txtTelefone.Text;
                leitor.CPF = txtCPF.Text;

                leitorBLL.AtualizarLeitor(leitor);
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

        public void ReceberDados(Leitor leitor)
        {

            txtId.Text = Convert.ToString(leitor.ID);
            txtNome.Text = leitor.Nome;
            txtEndereco.Text = leitor.Endereco;
            txtNumber.Text = Convert.ToString(leitor.Numero);
            txtTelefone.Text = leitor.Telefone;
            txtCPF.Text = leitor.CPF;

        }
    }
}
