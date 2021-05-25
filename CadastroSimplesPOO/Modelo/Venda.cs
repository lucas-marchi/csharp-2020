using Tarefa2209.Models;

namespace Tarefa2209.Models
{
    public class Venda
    {
        //Relacionamento com a classe cliente.
        //private Cliente cliente;
        public string VendaID { get; set; }
        public Cliente Cliente { get; set; }
        public string Veiculo { get; set; }

        public Venda(Cliente cliente, string veiculo)
        {
            this.Cliente = cliente;
            this.Veiculo = veiculo;
        }
        public Venda(string vendaID)
        {
            VendaID = vendaID;
        }
    }
}
