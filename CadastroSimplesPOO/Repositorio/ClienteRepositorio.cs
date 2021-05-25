using System;
using System.Collections.Generic;
using System.Linq;
using Tarefa2209.Models;

namespace Tarefa2209.Repositorio
{
    public class ClienteRepositorio
    {
        private readonly List<Cliente> clientes = new List<Cliente>();

        public void Gravar(Cliente cliente)
        {
            if (cliente.ClienteID == null) RegistrarCliente(cliente);
            else AtualizarCliente(cliente);
        }

        private void AtualizarCliente(Cliente cliente)
        {
            clientes.Find(m => m.ClienteID.Equals(cliente.ClienteID)).NomeCliente = cliente.NomeCliente;
        }

        public void RemoverCliente(String clienteID)
        {
            clientes.RemoveAll(m => m.ClienteID.Equals(clienteID));
        }

        public void RegistrarCliente(Cliente cliente)
        {
            cliente.ClienteID = Guid.NewGuid().ToString();
            clientes.Add(cliente);
        }

        public List<Cliente> ObterTodas()
        {
            return clientes;
        }

        public List<Cliente> ObterTodasClassificadasPorNome()
        {
            return ObterTodas().OrderBy(cliente => cliente.NomeCliente).ToList();
        }
    }
}
