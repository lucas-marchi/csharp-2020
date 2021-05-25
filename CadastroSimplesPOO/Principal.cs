using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tarefa2209.Models;
using Tarefa2209.Repositorio;

namespace Tarefa2209
{
    public partial class Principal : Form
    {
        private readonly ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public Cliente clienteAtual;
        public Principal()
        {
            InitializeComponent();
        }

        private bool ValidarDadosInformados()
        {
            if (tbNome.Text.Trim().Length == 0)
                return false;
            return true;
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidarDadosInformados())
            {
                MessageBox.Show("Dados incorretos", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            Cliente novoCliente;

            novoCliente = new Cliente(tbNome.Text, tbEndereco.Text);
            clienteRepositorio.Gravar(novoCliente);
            
            ReinicializarFormulario();
            AtualizarDataGridView();

            MessageBox.Show("Novo cadastro registrado", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar esta ação?", "Remover", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clienteRepositorio.RemoverCliente(clienteAtual.ClienteID);

                ReinicializarFormulario();
                AtualizarDataGridView();

                MessageBox.Show("Cadastro removido", "Sucesso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void AtualizarDataGridView()
        {
            dgvCadastro.DataSource = null;
            dgvCadastro.DataSource = clienteRepositorio.ObterTodasClassificadasPorNome();
        }

        private void ReinicializarFormulario()
        {
            tbNome.Clear();
            tbEndereco.Clear();
            btnExcluir.Enabled = false;
            tbNome.Focus();
            tbEndereco.Focus();
        }

        private void DgvCadastro_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String clienteID = dgvCadastro.Rows[e.RowIndex].Cells[0].Value.ToString();
            String clientenome = dgvCadastro.Rows[e.RowIndex].Cells[1].Value.ToString();
            String clienteendereco = dgvCadastro.Rows[e.RowIndex].Cells[2].Value.ToString();

            clienteAtual = new Cliente(clientenome, clienteendereco)
            {
                ClienteID = clienteID
            };
            tbNome.Text = clienteAtual.NomeCliente;
            tbEndereco.Text = clienteAtual.Endereco;

            btnLerTodos.Enabled = true;
            btnExcluir.Enabled = true;
            btnVenda.Enabled = true;
        }

        private void BtnLerTodos_Click(object sender, EventArgs e)
        {
            foreach (Cliente cliente in clienteRepositorio.ObterTodas())
            {
                MessageBox.Show(cliente.NomeCliente);
            }
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {
             RealizarVenda _f2;
             _f2 = new RealizarVenda(clienteAtual);
             _f2.Show();
        }
    }
}
