using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace UI
{
    public partial class CadastrarLivro : Form
    {
        private Livro livro;
        private LivroBLL livroBLL;
        public CadastrarLivro()
        {
            InitializeComponent();
            livroBLL = new LivroBLL();
            livro = new Livro();
            txtNome.Focus();
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
                        livro.Nome = txtNome.Text;
                        livro.Autor = txtAutor.Text;
                        livro.Genero = txtGenero.Text;
                        livro.Paginas = Convert.ToInt32(txtPaginas.Text);
                        livro.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                        livroBLL.SalvarLivro(livro);

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
                livro.ID = Convert.ToInt32(txtId.Text);
                livro.Nome = txtNome.Text;
                livro.Autor = txtAutor.Text;
                livro.Genero = txtGenero.Text;
                livro.Paginas = Convert.ToInt32(txtPaginas.Text);
                livro.Quantidade = Convert.ToInt32(txtQuantidade.Text);

                livroBLL.AlterarLivro(livro);
                MessageBox.Show("DADOS DO LIVRO ALTERADO COM SUCESSO!");

                ConsultarLivro frmConsultarLivro = new ConsultarLivro();
                frmConsultarLivro.Show();
                Close();
            }
        }
        public void ReceberDados(Livro livro)
        {

            txtId.Text = Convert.ToString(livro.ID);
            txtNome.Text = livro.Nome;
            txtAutor.Text = livro.Autor;
            txtGenero.Text = livro.Genero;
            txtPaginas.Text = Convert.ToString(livro.Paginas);
            txtQuantidade.Text = Convert.ToString(livro.Quantidade);

        }
    }
}
