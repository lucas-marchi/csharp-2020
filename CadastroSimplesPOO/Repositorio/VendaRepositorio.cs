using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefa2209.Models;

namespace Tarefa2209.Repositorio
{
    public class VendaRepositorio
    {
        private readonly List<Venda> vendas = new List<Venda>();

        public void GravarVenda(Venda venda)
        {
            if (venda.VendaID == null) RegistrarVenda(venda);
            else AtualizarVenda(venda);
        }

        private void AtualizarVenda(Venda venda)
        {
            vendas.Find(m => m.VendaID.Equals(venda.VendaID)).Veiculo = venda.Veiculo;
        }

        public void RegistrarVenda(Venda venda)
        {
            venda.VendaID = Guid.NewGuid().ToString();
            vendas.Add(venda);
        }
        public List<Venda> ObterTodos()
        {
            return vendas;
        }
        public List<Venda> ObterTodosVeiculos()
        {
            return ObterTodos().OrderBy(venda => venda.Veiculo).ToList();
        }
    }
}
