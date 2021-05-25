namespace Tarefa2209.Models
{
    public class Cliente
    {
        public string ClienteID { get; set; }
        public string NomeCliente { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nomecliente, string endereco)
        {
            this.NomeCliente = nomecliente;
            this.Endereco = endereco;
        }

        public Cliente(string clienteID)
        {
            ClienteID = clienteID;
        }
        public override string ToString()
        {
            return NomeCliente;
        }
    }
}
