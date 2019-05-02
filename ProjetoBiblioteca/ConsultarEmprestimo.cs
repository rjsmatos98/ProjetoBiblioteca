﻿using System;
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
    public partial class ConsultarEmprestimo : Form
    {
        Emprestimo emprestimo;
        EmprestimoBLL emprestimoBLL;
        public ConsultarEmprestimo()
        {
            InitializeComponent();
            emprestimo = new Emprestimo();
            emprestimoBLL = new EmprestimoBLL();
            AtualizarGrid();
            btnCancelar.Enabled = false;
            btnDevolucao.Enabled = false;
        }

        private void TxtLeitor_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void SelecionarRegistros(object sender, DataGridViewCellEventArgs e)
        {
            var listEmprestimo = emprestimoBLL.ConsultarEmprestimo(Convert.ToString(dgvEmprestimos.Rows[e.RowIndex].Cells[1].Value));
            foreach (Emprestimo empLeitor in listEmprestimo)
            {
                emprestimo.ID = empLeitor.ID;
                emprestimo.Leitor.ID = empLeitor.Leitor.ID;
                emprestimo.Leitor.Nome = Convert.ToString(empLeitor.Leitor);
                emprestimo.Livro.ID = empLeitor.Livro.ID;
                emprestimo.Livro.Nome = Convert.ToString(empLeitor.Livro);
                emprestimo.Retirada = Convert.ToString(empLeitor.Retirada);
                emprestimo.Devolucao = Convert.ToString(empLeitor.Devolucao);
            }
            btnCancelar.Enabled = true;
            btnDevolucao.Enabled = true;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar esse emprestimo?", "Atenção",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //Deleta registro


                emprestimoBLL.ExcluirEmprestimo(emprestimo);
                txtLeitor.Text = "";
                AtualizarGrid();
                btnCancelar.Enabled = false;
                btnDevolucao.Enabled = false;
            }
        }

        public void AtualizarGrid()
        {

            dgvEmprestimos.DataSource = null;
            dgvEmprestimos.DataSource = emprestimoBLL.ConsultarEmprestimo(txtLeitor.Text);
        }

        private void BtnDevolucao_Click(object sender, EventArgs e)
        {
            Devolucao FormDevolucao = new Devolucao();
            FormDevolucao.ReceberDados(emprestimo);
            FormDevolucao.Show();
            Close();
        }
    }
}
