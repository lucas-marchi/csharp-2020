using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarefa2209.Models;
using Tarefa2209.Repositorio;

namespace Tarefa2209
{
    public partial class RealizarVenda : Form
    {
        private readonly VendaRepositorio vendarepositorio = new VendaRepositorio();
        public Venda vendaAtual;
        private Cliente clienteAtual;

        public RealizarVenda(Cliente cliente)
        {
            InitializeComponent();
            clienteAtual = cliente;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Venda novaVenda;
            novaVenda = new Venda(clienteAtual, cbVeiculos.Text);
            vendarepositorio.GravarVenda(novaVenda);

            AtualizarDataGridView();
        }

        private void AtualizarDataGridView()
        {
            dgvVenda.DataSource = null;
            dgvVenda.DataSource = vendarepositorio.ObterTodosVeiculos();
        }

        private void DgvVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String vendaID = dgvVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            String clientecomprador = dgvVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            String veiculocomprado = dgvVenda.Rows[e.RowIndex].Cells[2].Value.ToString();

            vendaAtual = new Venda(clienteAtual, veiculocomprado)
            {
                VendaID = vendaID
            };
            clienteAtual.NomeCliente = clientecomprador;
            cbVeiculos.Text = vendaAtual.Veiculo;
        }
    }
}
