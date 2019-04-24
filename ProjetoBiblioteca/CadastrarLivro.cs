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
    public partial class CadastrarLivro : Form
    {
        LivroBD livro = new LivroBD();
        public CadastrarLivro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                if ((txtNome.Text != "") && (txtAutor.Text != "") && (txtGenero.Text != "") && (txtPaginas.Text != "") && (txtQuantidade.Text != ""))
                {

                    try
                    {
                        string strNome = txtNome.Text;
                        string strAutor = txtAutor.Text;
                        string strGenero = txtGenero.Text;
                        int intPaginas = Convert.ToInt32(txtPaginas.Text);
                        int intQuantidade = Convert.ToInt32(txtQuantidade.Text);

                        livro.SalvarLivro(strNome, strAutor, strGenero, intPaginas, intQuantidade);

                        //Exibe Mensagem!!

                        MessageBox.Show("LIVRO CADASTRADO COM SUCESSO!");

                        txtNome.Clear();
                        txtAutor.Clear();
                        txtQuantidade.Clear();
                        txtPaginas.Clear();
                        txtNome.Focus();

                    }

                    catch (System.FormatException)
                    {
                        MessageBox.Show("Certifique-se que você digitou um número no(s) campo(s) Páginas/Quantidade");

                    }

                }

                else
                {
                    MessageBox.Show("Certifique-se que todos os campos foram preenchidos!");
                    txtNome.Focus();
                }
            }
            else
            {
                int intId = Convert.ToInt32(txtId.Text);
                string strNome = txtNome.Text;
                string strAutor = txtAutor.Text;
                string strGenero = txtGenero.Text;
                int intPaginas = Convert.ToInt32(txtPaginas.Text);
                int intQuantidade = Convert.ToInt32(txtQuantidade.Text);

                livro.AlterarLivro(intId, strNome, strAutor, strGenero, intPaginas, intQuantidade);
                MessageBox.Show("DADOS DO LIVRO ALTERADO COM SUCESSO!");

                ConsultarLivro frmConsultarLivro = new ConsultarLivro();
                frmConsultarLivro.Show();
                Close();
            }
        }
        public void ReceberDados(string strNome, int intId, string strAutor, string strGenero, int intPaginas, int intQuantidade)
        {

            txtId.Text = Convert.ToString(intId);
            txtNome.Text = strNome;
            txtAutor.Text = strAutor;
            txtGenero.Text = strGenero;
            txtPaginas.Text = Convert.ToString(intPaginas);
            txtQuantidade.Text = Convert.ToString(intQuantidade);

        }
    }
}
